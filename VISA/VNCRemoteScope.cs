using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VncSharp;
using System.Drawing.Imaging;

namespace VISA
{
    public partial class VNCRemoteScope : Form
    {
        public VNCRemoteScope()
        {
            InitializeComponent();
        }

        private void connectScopeButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Get a host name from the user.
            string host = ConnectDialog.GetVncHost();

            //string host = "10.52.52.134";    // hardcoded for testing, of course

            // As long as they didn't click Cancel, try to connect
            // This is VNCsharp example code, which I could not get working in 2022. 
            /*
            if (host != null)
            {
                try
                {
                    rd.Connect(host);
                }
                catch (VncProtocolException vex)
                {
                    MessageBox.Show(this,
                                    string.Format("Unable to connect to VNC host:\n\n{0}.\n\nCheck that a VNC host is running there.", vex.Message),
                                    string.Format("Unable to Connect to {0}", host),
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this,
                                    string.Format("Unable to connect to host.  Error was: {0}", ex.Message),
                                    string.Format("Unable to Connect to {0}", host),
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }
            */

            // this is using RemoteViewing instead. It works. 
            if(host != null)
                vncControl1.Client.Connect(host);
        }

        private void disconnectScopeButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (vncControl1.Client.IsConnected)
            {
                vncControl1.Client.Close();
            }
        }

        private void VNCRemoteScope_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vncControl1.Client.IsConnected)
            {
                vncControl1.Client.Close();
            }
        }

        private void vncControl1_MouseEnter(object sender, EventArgs e)
        {
            // this is necessary to show the cursor when the mouse is over the Scope display. Otherwise the cursor disappears enirely 
            this.Cursor = Cursors.Default;
        }

        private void scopeScreenShotButton_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = new Bitmap(1024, 768);
            vncControl1.DrawToBitmap(bitmap, new Rectangle(0,0,1024,768));

            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;

            if(!filename.EndsWith(".png"))
            {
                filename += ".png";
            }

            bitmap.Save(filename, ImageFormat.Png);
        }

        private void updateClientStatusIndicator()
        {
            if (vncControl1.Client.IsConnected)
            {
                clientStatusTextBox.Text = ("Connected");
            }
            else
            { 
                clientStatusTextBox.Text = ("Disconnected");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateClientStatusIndicator();
        }
    }
}
