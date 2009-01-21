using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VLCTestApp.OSD
{
    public partial class HotKeyOsdChild : Form
    {

        #region hotkey
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);



        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
                switch ((int)m.WParam)
                {
                    case 501: MessageBox.Show("OKKK") ; break;
                    case 502: OSDInfo p = new OSDInfo(); p.Show(); break;
                    case 503: OSDInfo f = new OSDInfo(); f.Show(); break;
                    case 504: OSDInfo i = new OSDInfo(); i.Show(); break;
                    case 505: OSDInfo r = new OSDInfo(); r.Show(); break;
                    case 506: OSDInfo mm = new OSDInfo(); mm.Show(); break;
                }
            base.WndProc(ref m);
        }
        #endregion

        public HotKeyOsdChild()
        {
            InitializeComponent();
        }

        public void Register()
        {
            //37 i 39 right i left
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

        private void HotKeyOsdChild_Load(object sender, EventArgs e)
        {
            Register();
        }

        private void HotKeyOsdChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            Unregister();
        }
    }
}
