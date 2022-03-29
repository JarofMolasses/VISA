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

namespace VISA
{
    public partial class visaInterface : Form
    {
        const int CR = 0; const int CC = 1; const int CV = 2;
        StreamWriter outFile;

        List<MessageBasedSession> openSessionList = new List<MessageBasedSession>();          // i will declare an array here 

        // I-V test state
        bool testInProgress = false;

        public visaInterface()
        {
            InitializeComponent();

            // initialization code

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
            setupIVControlState();
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

        public int selectedOpenSessionIndex
        {
            get
            {
                return openResourcesListBox.SelectedIndex;
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

        private void availableResourcesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedString = (string)availableResourcesListBox.SelectedItem;
            ResourceName = selectedString;
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
                    openSessionList.Add((MessageBasedSession)rmSession.Open(ResourceName));          // initialize the VISA session
                    
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
            this.Cursor = Cursors.WaitCursor;     // makes sense in manual entry, not so much in automated mode
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(writeTextBox.Text);
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
                openSessionList[selectedOpenSessionIndex].RawIO.Write(textToWrite);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void readButton_MouseClick(object sender, MouseEventArgs e)
        {
            readTextBox.Text = String.Empty;
            //this.Cursor = Cursors.WaitCursor;     // use for manual entry
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
         * State function.
         * Controls the greying out of buttons - carried over from old code
         * Controls the updating of the list of active resources and the selected resource
         */
        private void SetupControlStateMaster()
        {
            // Update the open resources list boxes
            openResourcesListBox.Items.Clear();
            ivTargetDaqNameDropdown.Items.Clear();
            ivTargetLoadNameDropdown.Items.Clear();

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
            closeSessionButton.Enabled = isSessionOpen;
        }

        private void setupIVControlState()
        {
            bool isLoadSelected = false;
            if (ivTargetLoadIndex != -1)
            {
                isLoadSelected = true;
            }

            ivStartButton.Enabled = isLoadSelected;
            cancelButton.Enabled = isLoadSelected;
        }


        private void closeSessionButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int selectedOpenSessionToClose = -1;

            foreach (MessageBasedSession mb in openSessionList)
            {
                if (!mb.IsDisposed && mb.ResourceName.Equals(this.ResourceName))
                {
                    selectedOpenSessionToClose = openSessionList.IndexOf(mb);
                }
            }
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

        private string query(string queryString, int openSessionIndex)
        {
            readTextBox.Text = String.Empty;
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(queryString);
                writeTextBox.Text = textToWrite;

                openSessionList[openSessionIndex].RawIO.Write(textToWrite);
                
                readTextBox.Text = openSessionList[openSessionIndex].RawIO.ReadString();
                 Console.WriteLine(readTextBox.Text);
                return readTextBox.Text.ToString();
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

        private void ivStartButton_Click(object sender, EventArgs e)
        {
            runIVTest();
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

        private async void runIVTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            List<float> conditionList = new List<float>();
            float start = 0; float stop = 0; float step = 0;
  
            int mode = ivTabControl.SelectedIndex;
            string chartName = "";
            string chartTitle = "";
            bool cancelFlag = false;                // crude task cancellation. Best to use task cancellation token instead
            Int32 averageBuffer = 1;

            stopwatch.Start();

            string outFileName = "";
            if (averagingCheckBox.Checked)
            {
                averageBuffer = 24;
            }
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

                chartTitle = "I-V plot, Set voltage: " + Path.GetFileNameWithoutExtension(outFileName);
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
            int numSteps = 0;
            for (float value = start; value <= stop; value += step)
            {
                numSteps++;
                conditionList.Add(value);
            }

            chart1.Series.Clear();
            chart1.Series.Add(chartName);
            chart1.Series[chartName].ChartType = SeriesChartType.Line;
            chart2.Series.Clear();
            chart2.Series.Add(chartName);
            chart2.Series[chartName].ChartType = SeriesChartType.Line;

            testInProgress = true;
            outFile.WriteLine($"{chartName},Volts,Amps");
            foreach (float value in conditionList)
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
            
                loadOn();
                await Task.Delay((int)(float.Parse(stepTimeTextBox.Text.ToString()) * 1000));     // ivStepTime [s] * 1000 ms/s

                float volts = 0; float amps = 0;
                for (int i = 0; i < averageBuffer; i++)
                {
                    // if no external DAQ selected, use the load measurements
                    try
                    {
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
                            amps += shuntVolts * 200;           // specific shunt factor
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

                chart1.Series[chartName].Points.AddXY(volts, amps);
                chart2.Series[chartName].Points.AddXY(volts, amps);

                outFile.WriteLine($"{value.ToString()}, {volts.ToString()}, {amps.ToString()}");
            }

            loadOff();

            // horrible workaround to save a larger image of the chart. We make a copy which is large and invisible, chart2. Then save chart2.
            chart2.SaveImage($"{outFileName.Replace(".csv","")}.png", ChartImageFormat.Png);

            outFile.Close();
            testInProgress = false;

            stopwatch.Stop();
            Console.WriteLine("Elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);
        }

        private void setModeCR()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("CONF:REM ON\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CRL\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("RES 0\n");
        }

        private void setModeCC()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("CONF:REM ON\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CCH\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("CURR:STAT 0\n");
        }

        private void setModeCV()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("CONF:REM ON\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CVH\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("VOLT 0\n");
        }


        private void setLoadRes(float res)
        {
            //setModeCR();
            string resString = res.ToString();
            openSessionList[ivTargetLoadIndex].RawIO.Write($"RES:L1 {resString} OHM\n");
            Console.WriteLine($"Setting L1 CR to: {resString}");
        }
        
        private void setLoadCurr(float curr)
        {
            //setModeCC();
            string currString = curr.ToString();
            openSessionList[ivTargetLoadIndex].RawIO.Write($"CURR:STAT:L1 {currString}\n");
            Console.WriteLine($"Setting L1 CC to: {currString}");
        }

        private void setLoadVolts(float volts)
        {
            //setModeCV();
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

        private string stripFloatTerminators(string s)
        {
            s.Replace("\n", ""); 
            s.Replace("\n", "");

            return s;
        }

        private void cancelButton_MouseClick(object sender, MouseEventArgs e)
        {
            loadOff();
            Console.WriteLine("Test aborted");
            testInProgress = false;
        }

        private void queryIDShortcutButton_MouseClick(object sender, MouseEventArgs e)
        {
            writeTextBox.Text = @"*IDN?\n";
            query(writeTextBox.Text.ToString(), selectedOpenSessionIndex);
        }

        private void activeResourcesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string target = openResourcesListBox.SelectedItem.ToString();
            targetName = target;
        }

        private void targetLoadNameDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            setupIVControlState();
        }

        private void clearIVTargetSelectionButton_MouseClick(object sender, MouseEventArgs e)
        {
            ivTargetDaqNameDropdown.SelectedIndex = -1;
            ivTargetLoadNameDropdown.SelectedIndex = -1;
        }
    }

}
