using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vncRemoteScope
{
    public partial class VNCRemoteScope : Form
    {
        public VNCRemoteScope()
        {
            InitializeComponent();
        }

        private void VNCRemoteScope_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(rd.IsConnected)
            {
                rd.Disconnect();
            }

            base.OnClosing(e);          // i don't know what this does, honestly. it's important
        }

        public static string GetVncHost()
        {
            using (connectVNC dialog = new ConnectDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.Host;
                }
                else
                {
                    // If the user clicks Cancel, return null and not the empty string.
                    return null;
                }
            }
        }

    }
}
