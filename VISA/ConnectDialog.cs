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

namespace VISA
{
    public partial class ConnectDialog : Form
    {
        public ConnectDialog()
        {
            InitializeComponent();
            txtHost.Text = "10.52.52.134";      // hardcoded default to address of Agilent scope OSC016, change as needed
        }

        public string Host
        {
            get
            {
                return txtHost.Text;
            }
        }

        public static string GetVncHost()
        {
            using (ConnectDialog dialog = new ConnectDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.Host;
                }
                else
                {
                    // If the user clicks Cancel, return null
                    return null;
                }
            }
        }

        private void okButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // allow enter key to submit the Host address
        private void txtHost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Return)
                this.DialogResult = DialogResult.OK;
        }
    }
}
