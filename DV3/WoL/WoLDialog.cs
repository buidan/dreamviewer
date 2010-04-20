using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VLCTestApp
{
    public partial class WoLDialog : Form
    {
        public WoLDialog()
        {
            InitializeComponent();
        }

        private void wake_Click(object sender, EventArgs e)
        {
            WakeOnLan.WoL w = new WakeOnLan.WoL();
            w.WakeFunction(MacAddress.Text.Replace("-",""));
            this.Close();
        }

        private void WoLDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
