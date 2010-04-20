using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VLCTestApp.OSD
{
    public partial class OSDInfo : Form
    {
        public OSDInfo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OSDInfo_Load(object sender, EventArgs e)
        {
            int x = (SystemInformation.PrimaryMonitorSize.Height / 2) - (this.Size.Height /2);
            int y = SystemInformation.PrimaryMonitorSize.Width - this.Size.Width +70;
            this.Location = new Point(x,y);
        }
    }
}