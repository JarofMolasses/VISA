using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openVNChost
{
    public partial class connectVNChost : Form
    {
        public connectVNChost()
        {
            InitializeComponent();
        }

        public string Host
        {
            get
            {
                return vncHostNameTextBox.Text;
            }
        }


    }
}
