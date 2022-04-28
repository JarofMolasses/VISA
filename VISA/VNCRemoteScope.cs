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
            string host = ConnectDialog.GetVncHost();       // Get a host name from the user.

            // This is VNCsharp, which does not work.
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

            // This is using RemoteViewing instead.  
            if(host != null)
                vncControl1.Client.Connect(host);
                VNCRemoteScope.ActiveForm.Text = host; 
        }

        public void connectScope()
        {
            string host = ConnectDialog.GetVncHost();       // Get a host name from the user.

            // This is VNCsharp, which does not work.
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

            // This is using RemoteViewing instead.  
            if (host != null)
                vncControl1.Client.Connect(host);
            VNCRemoteScope.ActiveForm.Text = host;
        }
        private void disconnectScopeButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (vncControl1.Client.IsConnected)
            {
                vncControl1.Client.Close();
                VNCRemoteScope.ActiveForm.Text = "VNC remote scope";
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
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;

            if(!fileName.EndsWith(".png"))
            {
                fileName += ".png";
            }

            screenShot(fileName);
        }

        public void screenShot(string fileName)
        {
            Bitmap bitmap = new Bitmap(1024, 768);
            vncControl1.DrawToBitmap(bitmap, new Rectangle(0, 0, 1024, 768));

            bitmap.Save(fileName, ImageFormat.Png);
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
