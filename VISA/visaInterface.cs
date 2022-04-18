using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.Visa;
using System.Collections.Concurrent;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Threading;
using VncSharp;

namespace VISA
{
    public partial class visaInterface : Form
    {
        List<MessageBasedSession> openSessionList = new List<MessageBasedSession>();          // the key data structure of the program. this is a list of open VISA sessions.

        public visaInterface()
        {
            InitializeComponent();

            ChartArea ca = chart1.ChartAreas[0];
            ca.AxisX.LabelStyle.Format = "0.00";
            ca.AxisY.LabelStyle.Format = "0.00";

            ChartArea ca2 = chart2.ChartAreas[0];
            ca2.AxisX.LabelStyle.Format = "0.00";
            ca2.AxisY.LabelStyle.Format = "0.00";

            // I-V plot defaults
            resStepTextBox.Text = "0.25";
            stepTimeTextBox.Text = "0.5";

            SetupControlStateMaster();
            SetupIVControlState();
        }

        public string ResourceName
        {
            get
            {
                return visaResourceNameTextBox.Text;
            }
            set
            {
                visaResourceNameTextBox.Text = value;
            }
        }

        public string targetName
        {
            get
            {
                return selectedTargetResourceTextBox.Text;
            }

            set
            {
                selectedTargetResourceTextBox.Text = value;
            }
        }


        // Target session indices
        public int selectedOpenSessionIndex
        {
            get
            {
                return openResourcesListBox.SelectedIndex;
            }
        }
        public int ivTargetLoadIndex
        {
            get
            {
                return ivTargetLoadNameDropdown.SelectedIndex;
            }
        }

        public int ivTargetDaqIndex
        {
            get
            {
                return ivTargetDaqNameDropdown.SelectedIndex;
            }
        }


        private void findResourceButton_Click(object sender, EventArgs e)
        {
            // This example uses an instance of the NationalInstruments.Visa.ResourceManager class to find resources on the system.
            // Alternatively, static methods provided by the Ivi.Visa.ResourceManager class may be used when an application
            // requires additional VISA .NET implementations.
            using (var rmSession = new ResourceManager())
            {
                availableResourcesListBox.Items.Clear();
                var resources = rmSession.Find("(ASRL|GPIB|TCPIP|USB)?*");

                foreach (string s in resources)
                {
                    availableResourcesListBox.Items.Add(s);
                }
            }
        }
            
        private void availableResourcesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedString = (string)availableResourcesListBox.SelectedItem;
            ResourceName = selectedString;
            SetupControlStateMaster();
        }

        private void openSessionButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            using (var rmSession = new ResourceManager())
            {
                try
                {
                    openSessionList.Add((MessageBasedSession)rmSession.Open(ResourceName));          // initialize the VISA session and add it to the list of open sessions
                    SetupControlStateMaster();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Resource selected must be a message-based session");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }

        }

        private void queryButton_MouseClick(object sender, MouseEventArgs e)
        {
            readTextBox.Text = String.Empty;
            this.Cursor = Cursors.WaitCursor;     
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(writeTextBox.Text);
                if (appendLfCheckBox.Checked && !textToWrite.EndsWith("\n"))
                {
                    textToWrite += "\n";
                }
                openSessionList[selectedOpenSessionIndex].RawIO.Write(textToWrite);
                readTextBox.Text = InsertCommonEscapeSequences(openSessionList[selectedOpenSessionIndex].RawIO.ReadString());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void writeButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(writeTextBox.Text);
                if (appendLfCheckBox.Checked && !textToWrite.EndsWith("\n"))
                {
                    textToWrite += "\n";
                }
                openSessionList[selectedOpenSessionIndex].RawIO.Write(textToWrite);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void readButton_MouseClick(object sender, MouseEventArgs e)
        {
            read();
        }

        private void clearButton_MouseClick(object sender, MouseEventArgs e)
        {
            readTextBox.Text = String.Empty;
        }

        private string ReplaceCommonEscapeSequences(string s)
        {
            return s.Replace("\\n", "\n").Replace("\\r", "\r");
        }

        private string InsertCommonEscapeSequences(string s)
        {
            return s.Replace("\n", "\\n").Replace("\r", "\\r");
        }

        /*
         * Controls the greying out of buttons in the Session control and Read/Write sections
         * Controls the updating of the list of active resources and the selected resource 
         * 
         * call whenever resources are added or removed
         */
        private void SetupControlStateMaster()
        {
            // Update the open resources list boxes
            openResourcesListBox.Items.Clear();
            ivTargetDaqNameDropdown.Items.Clear();
            ivTargetLoadNameDropdown.Items.Clear();

            // fill out the listboxes
            foreach (MessageBasedSession mb in openSessionList)
            {
                if (mb != null && !mb.IsDisposed)      // possibly redundant. There are only open sessions in the openSessionList
                {
                    openResourcesListBox.Items.Add(mb.ResourceName.ToString());
                    ivTargetDaqNameDropdown.Items.Add(mb.ResourceName.ToString());
                    ivTargetLoadNameDropdown.Items.Add(mb.ResourceName.ToString());
                }
            }
            // Grey out the open/close buttons based on selected session from all available sessions
            bool isSessionOpen = false;
            int selectedSessionIndex = -1;

            foreach (MessageBasedSession mb in openSessionList)
            {
                if (!mb.IsDisposed && mb.ResourceName.Equals(this.ResourceName))
                {
                    selectedSessionIndex = openSessionList.IndexOf(mb);
                }
            }

            if (selectedSessionIndex != -1 && !openSessionList[selectedSessionIndex].IsDisposed)
            {
                isSessionOpen = true;
                readTextBox.Text = String.Empty;
                writeTextBox.Focus();
            }

            openSessionButton.Enabled = !isSessionOpen;

            if (openResourcesListBox.SelectedIndex != -1)
            {
                closeSessionButton.Enabled = true;      // that's messy. I shouldn't be handling this here, it should be consolidated in setupcontrolstatemaster or something
            }
            else
            {
                closeSessionButton.Enabled = false;
            }

            selectedTargetResourceTextBox.Clear();
            openResourcesIDListBox.Items.Clear();
        }

        private void scanResourceIDs()
        {
            openResourcesIDListBox.Items.Clear();
            foreach (MessageBasedSession mb in openSessionList)
            {
                try
                {
                    string resourceID = query("*IDN?\n", openSessionList.IndexOf(mb));
                    openResourcesIDListBox.Items.Add(resourceID);
                }
                catch (Ivi.Visa.IOTimeoutException)
                {
                    openResourcesIDListBox.Items.Add("Unrecognized instrument");
                }
            }
        }

        private void closeSessionButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            int selectedOpenSessionToClose = openResourcesListBox.SelectedIndex;
            try
            {
                openSessionList[selectedOpenSessionToClose].Dispose();
                openSessionList.RemoveAt(selectedOpenSessionToClose);
                SetupControlStateMaster();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        // automatic query method 
        private string query(string queryString, int openSessionIndex)
        {
            readTextBox.Text = String.Empty;
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(queryString);
                Console.WriteLine(textToWrite);
                openSessionList[openSessionIndex].RawIO.Write(textToWrite);
  
                string response = openSessionList[openSessionIndex].RawIO.ReadString();
                Console.WriteLine("Response: " + response);
                return response;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return "";
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // I-V test globals
        StreamWriter outFile;                                                                 // output file writer initialization
        bool testInProgress = false;                                                          // state variable used to cancel the test
        const int CR = 0; const int CC = 1; const int CV = 2;                                 // enumerating modes for the I-V test 

        private void ivStartButton_Click(object sender, EventArgs e)
        {
            runIVTest();
        }

        // For responsive UI: use async and await instead of blocking.
        private async void runIVTest()
        {
            testInProgress = true;
            SetupIVControlState();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            testRunningIndicatorTextBox.BackColor = Color.Red;
            
            bool cancelFlag = false;                                                              // crude task cancellation. Best to use task cancellation token instead
            List<float> loadConditionList = new List<float>();                                     // list of test condition values for the DC load
            float start = 0; float stop = 0; float step = 0;
  
            int mode = ivTabControl.SelectedIndex;                                               // Using the enumeration declared earlier, tab 0 = CR, tab 1 = CC, tab 2 = CV
            string chartName = "";
            string chartTitle = "";
            string outFileName = "";

            Int32 averageBuffer = 1;
            if (averagingCheckBox.Checked)
            {
                averageBuffer = 24;
            }

            openSessionList[ivTargetLoadIndex].RawIO.Write("CONF:REM ON\n");      
            switch (mode)
            {
                case CR:
                    chartName = "CR";
                    start = float.Parse(startResTextBox.Text);
                    stop = float.Parse(stopResTextBox.Text);
                    step = float.Parse(resStepTextBox.Text);
                    setModeCR();
                    break;
                case CC:
                    chartName = "CC";
                    start = float.Parse(startCurrentTextBox.Text);
                    stop = float.Parse(stopCurrentTextBox.Text);
                    step = float.Parse(curStepTextBox.Text);
                    setModeCC();
                    break;
                case CV:
                    chartName = "CV";
                    start = float.Parse(startVoltageTextBox.Text);
                    stop = float.Parse(stopVoltageTextBox.Text);
                    step = float.Parse(voltStepTextBox.Text);
                    setModeCV();
                    break;
            }

            // Generate plot labels and output files
            // TODO: should maybe add indicator of CC/CR/CV mode in the file name
            try
            {
                if (!fileNameTextBox.Text.EndsWith(".csv"))
                {
                    outFileName = fileNameTextBox.Text + ".csv";
                }
                else
                {
                    outFileName = fileNameTextBox.Text;
                }
                outFile = new StreamWriter($"{outFileName}");         // auto append .csv if not already present in filename

                chartTitle = "Current[A] vs voltage[V], file: " + Path.GetFileNameWithoutExtension(outFileName);
                chart1.Titles.Clear();
                chart2.Titles.Clear();
                chart1.Titles.Add(chartTitle);
                chart1.Series.Clear();
                chart2.Titles.Add(chartTitle);
                chart2.Series.Clear();
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("File path is empty");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("File is currently open");
            }


            // create list of load conditions - if proportional steps option is checked in resistance mode, then increment by percentage instead of fixed step
            int numSteps = 0;
            if(mode == CR && proportionalStepsCheckBox.Checked)
            {
                for (float value = start; value <= stop; value += value * (step/100))       // convert step percent to dimensionless
                {
                    numSteps++;
                    loadConditionList.Add(value);
                }
            }
            else
            {
                for (float value = start; value <= stop; value += step)
                {
                    numSteps++;
                    loadConditionList.Add(value);
                }
            }
            
            chart1.Series.Clear();
            chart1.Series.Add(chartName);
            chart1.Series[chartName].ChartType = SeriesChartType.Line;
            chart2.Series.Clear();
            chart2.Series.Add(chartName);
            chart2.Series[chartName].ChartType = SeriesChartType.Line;

            testInProgress = true;
            outFile.WriteLine($"{chartName},Volts,Amps,Power");
            foreach (float value in loadConditionList)
            {
                numSteps--;
                testProgressTextBox.Text = $"Steps remaining: {numSteps}";
                try
                {
                    switch (mode)
                    {
                        case CR:
                            setLoadRes(value);
                            break;
                        case CC:
                            setLoadCurr(value);
                            break;
                        case CV:
                            setLoadVolts(value);
                            break;
                    }
                }
                catch (Exception exp)
                {
                    cancelFlag = true;
                    break;         
                }
                await Task.Delay(50);
                loadOn();
                await Task.Delay((int)(float.Parse(stepTimeTextBox.Text.ToString()) * 1000));     // ivStepTime [s] * 1000 ms/s

                float volts = 0; float amps = 0; float power = 0;
                for (int i = 0; i < averageBuffer; i++)
                {
                    try
                    { 
                        // if no external DAQ selected, use the load measurements
                        if(ivTargetDaqIndex == -1)
                        { 
                            volts += float.Parse(query("MEAS:VOLT?\n", ivTargetLoadIndex));
                            amps += float.Parse(query("MEAS:CURR?\n", ivTargetLoadIndex));
                            await Task.Delay(100);
                        }
                        // else use the external DAQ measurements
                        else
                        {
                            volts += float.Parse(query("MEAS:VOLT:DC? (@101)\n", ivTargetDaqIndex));
                            float shuntVolts = float.Parse(query("MEAS:VOLT:DC? (@102)\n", ivTargetDaqIndex));
                            amps += shuntVolts * 200;           // shunt resistance factor = 1/R
                        }
                    }
                    catch(Exception exp)
                    {
                        cancelFlag = true;
                        break;
                    }
                }

                if(cancelFlag || !testInProgress)           // either instrument disconnected, or the test was aborted
                {
                    break;
                }

                volts /= (float)averageBuffer;
                amps /= (float)averageBuffer;
                power = volts * amps;

                chart1.Series[chartName].Points.AddXY(volts, amps);
                chart2.Series[chartName].Points.AddXY(volts, amps);

                outFile.WriteLine($"{value.ToString()},{volts.ToString()},{amps.ToString()},{power.ToString()}");
            }
            loadOff();

            // horrible workaround to save a larger image of the chart. We make a copy which is large and invisible, chart2. Then save chart2.
            chart2.SaveImage($"{outFileName.Replace(".csv", "")}.png", ChartImageFormat.Png);

            outFile.Close();
            stopwatch.Stop();
            Console.WriteLine("Elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);
            testRunningIndicatorTextBox.BackColor = Color.White;

            testInProgress = false;
            SetupIVControlState();
        }

        private void setModeCR()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CRL\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("RES 0\n");
        }

        private void setModeCC()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CCH\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("CURR:STAT 0\n");
        }

        private void setModeCV()
        { 
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CVH\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("VOLT 0\n");
        }


        private void setLoadRes(float res)
        {
            string resString = res.ToString();
            openSessionList[ivTargetLoadIndex].RawIO.Write($"RES:L1 {resString} OHM\n");
            Console.WriteLine($"Setting L1 CR to: {resString}");
        }
        
        private void setLoadCurr(float curr)
        {
            string currString = curr.ToString();
            openSessionList[ivTargetLoadIndex].RawIO.Write($"CURR:STAT:L1 {currString}\n");
            Console.WriteLine($"Setting L1 CC to: {currString}");
        }

        private void setLoadVolts(float volts)
        {
            string voltsString = volts.ToString();
            openSessionList[ivTargetLoadIndex].RawIO.Write($"VOLT:L1 {voltsString}\n");
            Console.WriteLine($"Setting L1 CV to: {voltsString}");
        }

        private void loadOn()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("LOAD ON\n");
            Console.WriteLine("Setting Load ON");
        }

        private void loadOff()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("LOAD OFF\n");
            Console.WriteLine("Setting Load OFF");
        }
        private void selectFileButton_MouseClick(object sender, MouseEventArgs e)
        {
            saveFileDialog1.ShowDialog();
            fileNameTextBox.Text = saveFileDialog1.FileName;
        }

        private void cancelButton_MouseClick(object sender, MouseEventArgs e)
        {
            loadOff();
            Console.WriteLine("Test aborted");
            testProgressTextBox.Clear();                // clear this so it's evident the test is canceled

            testRunningIndicatorTextBox.BackColor = Color.White;

            testInProgress = false;
            SetupIVControlState();
        }

        private void queryIDShortcutButton_MouseClick(object sender, MouseEventArgs e)
        {
            writeTextBox.Text = "*IDN?\n";
            openSessionList[selectedOpenSessionIndex].RawIO.Write(writeTextBox.Text);

            read();
        }

        private void targetLoadNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupIVControlState();
        }

        private void clearIVTargetSelectionButton_MouseClick(object sender, MouseEventArgs e)
        {
            ivTargetDaqNameDropdown.SelectedIndex = -1;
            ivTargetLoadNameDropdown.SelectedIndex = -1;
        }

        private void read()
        {
            readTextBox.Text = String.Empty;
            try
            {
                readTextBox.Text = InsertCommonEscapeSequences(openSessionList[selectedOpenSessionIndex].RawIO.ReadString());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void scanResourceIDsButton_Click(object sender, EventArgs e)
        {
            scanResourceIDs();
        }

        // Dispose of all sessions on form close. This seems to prevent the DC Load from dropping out and requiring power cycle.
        private void visaInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(MessageBasedSession mb in openSessionList)
            {
                mb.Dispose();
            }
            openSessionList.Clear();
        }

        // Controls the greying out of buttons in the IV section
        private void SetupIVControlState()
        {
            bool isLoadSelected = false;
            if (ivTargetLoadIndex != -1)
            {
                isLoadSelected = true;
            }

            ivStartButton.Enabled = isLoadSelected && !testInProgress;
            cancelButton.Enabled = isLoadSelected;

            stepTimeTextBox.Enabled = !testInProgress;
            ivTabControl.Enabled = !testInProgress;
            clearIVTargetSelectionButton.Enabled = !testInProgress;
            ivTargetDaqNameDropdown.Enabled = !testInProgress;
            ivTargetLoadNameDropdown.Enabled = !testInProgress;

            averagingCheckBox.Enabled = !testInProgress;
            selectFileButton.Enabled = !testInProgress;
        }

        private void openResourcesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTargetResourceTextBox.Text = openResourcesListBox.SelectedItem.ToString();
            if(openResourcesListBox.SelectedIndex != -1)
            {
                closeSessionButton.Enabled = true;      
            }
            else
            {
                closeSessionButton.Enabled = false;
            }
        }

        private void openRemoteScope_MouseClick(object sender, MouseEventArgs e)
        {
            VNCRemoteScope scope = new VNCRemoteScope();
            scope.Show();

        }

        private void proportionalStepsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (proportionalStepsCheckBox.Checked)
                stepTypeLabel.Text = @"[%]:";
            else
                stepTypeLabel.Text = @"[R]:";
        }
    }

}
