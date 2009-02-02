using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VLCTestApp.OSD
{
    public partial class OSDChanList : Form
    {
        public OSDChanList()
        {
            InitializeComponent();
            flowControl1.Load("d:\\slike");
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
