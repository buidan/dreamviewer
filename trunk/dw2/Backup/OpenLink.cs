using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VLCTestApp
{
    public partial class OpenLink : Form
    {
        public OpenLink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VLCTestApp.ViewVideo.gEkran.Stop();
            VLCTestApp.ViewVideo.gEkran.AddTarget(uri.Text);
            VLCTestApp.ViewVideo.gEkran.Play();
            this.Close();
        }
    }
}