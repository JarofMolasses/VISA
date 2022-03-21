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
using Ivi.Visa;

namespace VISA
{
    public partial class visaInterface : Form
    {
        StreamWriter outFile;

        private MessageBasedSession mbSession;

        Int32 averageBuffer = 24;
        Int32 plotBufferLimit = 256; // failsafe, don't accumulate huge amounts of plot data in memory

        // I-V test variables
        Int32 ivStepTime = 1;         // default test period 1 second
        bool testInProgress = false;

        Queue<float> voltPlotQueue = new Queue<float>();
        Queue<float> ampsPlotQueue = new Queue<float>();
        public visaInterface()
        {
            InitializeComponent();

            // initialization code
            chart1.Titles.Add("I-V plot");
            chart1.Series.Clear();
            chart1.Series.Add("CR");
            chart1.Series["CR"].ChartType = SeriesChartType.Line;
            chart1.Series["CR"].Points.DataBindXY(voltPlotQueue, ampsPlotQueue);

            ChartArea ca = chart1.ChartAreas[0];
            ca.AxisX.LabelStyle.Format = "0.00";
            ca.AxisY.LabelStyle.Format = "0.00";

            // I-V plot defaults
            resStepTextBox.Text = "0.5";
            stepTimeTextBox.Text = $"{ivStepTime.ToString()}";
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
        }

        private void openSessionButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            using (var rmSession = new ResourceManager())
            {
                try
                {
                    mbSession = (MessageBasedSession)rmSession.Open(ResourceName);          // initialize the VISA session. TODO: allow for multiple simultaneous sessions. Have a list box with "active resources", and option to clear specific ones.
                    SetupControlState(true);
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
                mbSession.RawIO.Write(textToWrite);
                readTextBox.Text = InsertCommonEscapeSequences(mbSession.RawIO.ReadString());
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
                mbSession.RawIO.Write(textToWrite);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void readButton_MouseClick(object sender, MouseEventArgs e)
        {
            readTextBox.Text = String.Empty;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                readTextBox.Text = InsertCommonEscapeSequences(mbSession.RawIO.ReadString());
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
         * Controls the greying out of panels - carried over from old code
         */
        private void SetupControlState(bool isSessionOpen)
        {
            openSessionButton.Enabled = !isSessionOpen;
            closeSessionButton.Enabled = isSessionOpen;
            queryButton.Enabled = isSessionOpen;
            writeButton.Enabled = isSessionOpen;
            readButton.Enabled = isSessionOpen;
            writeTextBox.Enabled = isSessionOpen;
            clearButton.Enabled = isSessionOpen;
            if (isSessionOpen)
            {
                readTextBox.Text = String.Empty;
                writeTextBox.Focus();
            }
        }

        private void closeSessionButton_MouseClick(object sender, MouseEventArgs e)
        {
            SetupControlState(false);
            mbSession.Dispose();
        }

        private string query()
        {
            readTextBox.Text = String.Empty;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(writeTextBox.Text);
                mbSession.RawIO.Write(textToWrite);
                //readTextBox.Text = InsertCommonEscapeSequences(mbSession.RawIO.ReadString());
                readTextBox.Text = mbSession.RawIO.ReadString();
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

        private async void ivStartButton_Click(object sender, EventArgs e)
        {
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
            finally
            {
                // nothing, really.
            }

            if (resStepTextBox.Text == "" || startResTextBox.Text == "" || stopResTextBox.Text == "" || float.Parse(startResTextBox.Text) > float.Parse(stopResTextBox.Text))
            {
                MessageBox.Show("Invalid test conditions");
            }
            else
            {
                testInProgress = true;
                Queue<float> resistanceList = new Queue<float>();
                float start = float.Parse(startResTextBox.Text); float stop = float.Parse(stopResTextBox.Text); float step = float.Parse(resStepTextBox.Text);
               
                int numSteps = 0;
                for (float res = start; res <= stop; res += step)
                {
                    numSteps++;
                    resistanceList.Enqueue(res);
                }

                outFile.WriteLine("CR,Volts,Amps");
                mbSession.RawIO.Write("RES 0\n");
                setLoadRes(resistanceList.Peek().ToString());
                loadOn();
                foreach (float r in resistanceList)
                {
                    numSteps--;
                    testProgressTextBox.Text = $"Steps remaining: {numSteps}";
                    
                    setLoadRes(r.ToString());
                    await Task.Delay(int.Parse(stepTimeTextBox.Text.ToString())*1000);     // ivStepTime [s] * 1000 ms/s
                    
                    float volts = 0; float amps = 0;
                    for(int i = 0; i < averageBuffer && testInProgress == true; i++)
                    {
                        writeTextBox.Text = "MEAS:VOLT?\n";
                        volts += float.Parse(stripFloatTerminator(query()));
                        writeTextBox.Text = "MEAS:CURR?\n";
                        amps += float.Parse(stripFloatTerminator(query()));

                        await Task.Delay(100);              // basic delay between averaging readings
                    }
                    volts/= (float)averageBuffer;
                    amps /= (float)averageBuffer;

                    voltPlotQueue.Enqueue(volts);
                    ampsPlotQueue.Enqueue(amps);
                    if(voltPlotQueue.Count > plotBufferLimit) // limits I-V plot buffer 
                    {
                        voltPlotQueue.Dequeue();
                        ampsPlotQueue.Dequeue();
                    }

                    chart1.Series["CR"].Points.AddXY(volts, amps);

                    outFile.WriteLine($"{r.ToString()}, {volts.ToString()}, {amps.ToString()}");
                }
                loadOff();
                outFile.Close();
                testInProgress = false;
            }
        }

        private void selectFileButton_MouseClick(object sender, MouseEventArgs e)
        {
            saveFileDialog1.ShowDialog();
            fileNameTextBox.Text = saveFileDialog1.FileName;
        }

        private void setLoadRes(string resString)
        {
            mbSession.RawIO.Write($"RES:L1 {resString} OHM\n");
            Console.WriteLine($"Setting L1 CR to: {resString}");

            writeTextBox.Text = "RES:L1?\n";    // bruh. you are writing in the textbox and then running query() smh. 
            query();
        }

        private void loadOn()
        {
            mbSession.RawIO.Write("LOAD ON\n");
            Console.WriteLine("Setting Load ON");
        }

        private void loadOff()
        {
            mbSession.RawIO.Write("LOAD OFF\n");
            Console.WriteLine("Setting Load OFF");
        }

        private string stripFloatTerminator(string s)
        {
            if (s.EndsWith("\n"))
            {
                s.Replace('\n', '0');
            }

            return s;
        }

        private void cancelButton_MouseClick(object sender, MouseEventArgs e)
        {
            loadOff();
            mbSession.Dispose();
            Console.WriteLine("Test aborted");
            testInProgress = false;
            
            // todo: this allows the window to be safely closed if you need to change the setup. However, this is not elegant and means if you cancel the test, you need to relaunch the form. 
            // Needs adjustment to elegantly cancel test without needing to relaunch
        }

    }


}
