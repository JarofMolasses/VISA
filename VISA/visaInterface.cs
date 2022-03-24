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

namespace VISA
{
    public partial class visaInterface : Form
    {
        const int CR = 0; const int CC = 1; const int CV = 2;
        StreamWriter outFile;

        List<MessageBasedSession> openSessionList = new List<MessageBasedSession>();          // i will declare an array here 

        // I-V test variables
        Int32 ivStepTime = 2;         // default test period 1 second
        bool testInProgress = false;

        public visaInterface()
        {
            InitializeComponent();

            // initialization code
            chart1.Titles.Add("I-V plot");
            chart1.Series.Clear();

            ChartArea ca = chart1.ChartAreas[0];
            ca.AxisX.LabelStyle.Format = "0.00";
            ca.AxisY.LabelStyle.Format = "0.00";

            // I-V plot defaults
            resStepTextBox.Text = "0.25";
            stepTimeTextBox.Text = $"{ivStepTime.ToString()}";

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
            Queue<float> conditionList = new Queue<float>();
            float start = 0; float stop = 0; float step = 0;
            int mode = ivTabControl.SelectedIndex;
            string chartName = "";
            Int32 averageBuffer = 10;

            if (averagingCheckBox.Checked)
            {
                averageBuffer = 32;
            }
            try
            {
                if (!fileNameTextBox.Text.EndsWith(".csv"))
                {
                    fileNameTextBox.Text += ".csv";
                }
                outFile = new StreamWriter($"{ fileNameTextBox.Text }");         // auto append .csv if not already present in filename
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
                    break;
                case CC:
                    chartName = "CC";
                    start = float.Parse(startCurrentTextBox.Text);
                    stop = float.Parse(stopCurrentTextBox.Text);
                    step = float.Parse(curStepTextBox.Text);
                    break;
                case CV:
                    chartName = "CV";
                    start = float.Parse(startVoltageTextBox.Text);
                    stop = float.Parse(stopVoltageTextBox.Text);
                    step = float.Parse(voltStepTextBox.Text);
                    break;
            }
            int numSteps = 0;
            for (float value = start; value <= stop; value += step)
            {
                numSteps++;
                conditionList.Enqueue(value);
            }

            chart1.Series.Clear();
            chart1.Series.Add(chartName);
            chart1.Series[chartName].ChartType = SeriesChartType.Line;

            testInProgress = true;
            outFile.WriteLine($"{chartName},Volts,Amps");
            foreach(float value in conditionList)
            {
                numSteps--;
                testProgressTextBox.Text = $"Steps remaining: {numSteps}";

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

                loadOn();
                await Task.Delay(int.Parse(stepTimeTextBox.Text.ToString()) * 1000);     // ivStepTime [s] * 1000 ms/s

                float volts = 0; float amps = 0;
                for (int i = 0; i < averageBuffer; i++)
                {
                    // if no external DAQ selected, use the load measurements
                    if(ivTargetDaqIndex == -1)
                    { 
                        volts += float.Parse(query("MEAS:VOLT?\n", ivTargetLoadIndex));
                        amps += float.Parse(query("MEAS:CURR?\n", ivTargetLoadIndex));
                        await Task.Delay(50);
                    }
                    // else use the external DAQ measurements
                    else
                    {
                        volts += float.Parse(query("MEAS:VOLT:DC? (@101)\n", ivTargetDaqIndex));
                        float shuntVolts = float.Parse(query("MEAS:VOLT:DC? (@102)\n", ivTargetDaqIndex));
                        amps += shuntVolts * 200;
                        await Task.Delay(20);              // basic delay between averaging readings
                    }

                    
                }
                volts /= (float)averageBuffer;
                amps /= (float)averageBuffer;

                chart1.Series[chartName].Points.AddXY(volts, amps);

                outFile.WriteLine($"{value.ToString()}, {volts.ToString()}, {amps.ToString()}");
            }

            loadOff();
            outFile.Close();
            testInProgress = false;
        }

        private void setLoadCR()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("CONF:REM ON\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CRL\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("RES 0\n");
        }

        private void setLoadCC()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("CONF:REM ON\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CCH\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("CURR:STAT 0\n");
        }

        private void setLoadCV()
        {
            openSessionList[ivTargetLoadIndex].RawIO.Write("CONF:REM ON\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("MODE CVH\n");
            openSessionList[ivTargetLoadIndex].RawIO.Write("VOLT 0\n");
        }


        private void setLoadRes(float res)
        {
            setLoadCR();
            string resString = res.ToString();
            openSessionList[ivTargetLoadIndex].RawIO.Write($"RES:L1 {resString} OHM\n");
            Console.WriteLine($"Setting L1 CR to: {resString}");
        }
        
        private void setLoadCurr(float curr)
        {
            setLoadCC();
            string currString = curr.ToString();
            openSessionList[ivTargetLoadIndex].RawIO.Write($"CURR:STAT:L1 {currString}\n");
            Console.WriteLine($"Setting L1 CC to: {currString}");
        }

        private void setLoadVolts(float volts)
        {
            setLoadCV();
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
            openSessionList.Clear();
            Console.WriteLine("Test aborted");
            testInProgress = false;
            
            // todo: this allows the window to be safely closed if you need to change the setup. However, this is not elegant and means if you cancel the test, you need to relaunch the form. 
            // Needs adjustment to elegantly cancel test without needing to relaunch
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
