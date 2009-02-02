using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VLCTestApp
{
    public partial class OpenLink : Form
    {
        #region hotkey
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        ViewVideo roditelj;


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
                switch ((int)m.WParam)
                {
                    case 501: roditelj.nextChan(); break;
                    case 502: roditelj.prevChan(); break;
                    case 503: VLCTestApp.ViewVideo.gEkran.ToggleFullscreen() ; break;
                    case 504: OSD.OSDInfo i = new OSD.OSDInfo(); i.Show(); break;
                    case 505: OSD.OSDInfo r = new OSD.OSDInfo(); r.Show(); break;
                    case 506: VLCTestApp.ViewVideo.gEkran.VolumeMute(); break;
                }
            base.WndProc(ref m);
        }
        #endregion

        public OpenLink(ViewVideo v)
        {
            InitializeComponent();
            roditelj = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void Register()
        {
            bool success = RegisterHotKey(this.Handle, 501, 0, 38);
            success = RegisterHotKey(this.Handle, 502, 0, 50);
            success = RegisterHotKey(this.Handle, 503, 0, 70);
            success = RegisterHotKey(this.Handle, 504, 0, 73);
            success = RegisterHotKey(this.Handle, 505, 0, 82);
            success = RegisterHotKey(this.Handle, 506, 0, 77);
        }

        public void Unregister()
        {
            UnregisterHotKey(this.Handle, 501);
            UnregisterHotKey(this.Handle, 502);
            UnregisterHotKey(this.Handle, 503);
            UnregisterHotKey(this.Handle, 504);
            UnregisterHotKey(this.Handle, 505);
            UnregisterHotKey(this.Handle, 506);
        }
        private void OpenLink_Load(object sender, EventArgs e)
        {
            Register();
        }

        private void OpenLink_FormClosed(object sender, FormClosedEventArgs e)
        {
            Unregister();
        }
    }
}