using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;


namespace VLCTestApp
{
    public partial class ViewVideo : Form
    {

        #region hotkey
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        private OSD.OSDChanList oc;
        private OSD.OSDInfo oi;
        private Settings.Settings AppSettings;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
                switch ((int)m.WParam)
                {
                    case 401: nextChannelToolStripMenuItem_Click(this, null); break;
                    case 402: previuseToolStripMenuItem_Click(this, null); break;
                    case 403: vlc.ToggleFullscreen(); break;
                    case 404: if (!isFull()) channelInfoToolStripMenuItem_Click(this, null);
                        else {
                            if (oi == null) oi = new OSD.OSDInfo();
                            if (!oi.Visible) oi.Show(); else oi.Hide();
                    }
                        break;
                      //  if (!full) channelInfoToolStripMenuItem_Click(this, null); break;
                   // case 405: rEcordToolStripMenuItem_Click(this, null); break;
                    case 405: MessageBox.Show(isFull().ToString()); break;
                    case 406: muteToolStripMenuItem_Click(this, null);  break;
                    case 407: if (!isFull()) channelListToolStripMenuItem_Click(this, null);
                        else
                        {
                            if (oc == null) oc = new OSD.OSDChanList();
                            if (!oc.Visible) oc.Show(); else oc.Hide();
                        }
                        break;
                    case 408: if (!isFull()) flowControl1.GoToPrevious(); else OSD.OSDChanList.flowControl1.GoToPrevious(); break;
                    case 409: if (!isFull()) flowControl1.GoToNext(); else OSD.OSDChanList.flowControl1.GoToNext(); break;
                    //case 410: if(chan_menu.Visible || oc.Visible) MessageBox.Show("Change Chan"); break;
                    case 411: if (isFull()) { if (oc != null && oc.Visible) oc.Hide(); else vlc.ToggleFullscreen(); } break;
                }
            base.WndProc(ref m);
        }
        #endregion

        private bool isFull()
        {
            StringBuilder Buff = new StringBuilder(256);
            if (GetWindowText(GetForegroundWindow(), Buff, 256) > 0)
                if (Buff.ToString() == "VLC (hardware YUV overlay DirectX output)")
                    return true;
            return false;
        }


        private static LibVlc vlc;

        // Net :)
        private Socket client;
        private byte[] data = new byte[1024];
        private int size = 1024;

        public static LibVlc gEkran
        {
            get { return vlc; }
            set { vlc = value; }
        }

        public  void nextChan()
        {
            nextChannelToolStripMenuItem_Click(this,null);
        }
        public  void prevChan()
        {
            previuseToolStripMenuItem_Click(this,null);
        }

        public ViewVideo()
        {
            InitializeComponent();

            loadSettings();

            initializeVLC();

            initializHotKeys();
        }

        private void loadSettings()
        {
            if (File.Exists("Settings.dat"))
            {
                FileStream fs;
                AppSettings = (Settings.Settings)(new BinaryFormatter()).Deserialize(fs =File.Open("Settings.dat", FileMode.Open));
                fs.Close();
            }
            else MessageBox.Show("Settngs file doesn't exists");
        }

        private void initializHotKeys()
        {
            //37 i 39 right i left
            bool success = RegisterHotKey(this.Handle, 401, 0, 38); // UP
            success = RegisterHotKey(this.Handle, 402, 0, 40);   // DOWN
            success = RegisterHotKey(this.Handle, 403, 0, 70); // F
            success = RegisterHotKey(this.Handle, 404, 0, 73); // I
            success = RegisterHotKey(this.Handle, 405, 0, 82); // R
            success = RegisterHotKey(this.Handle, 406, 0, 77); // M 
            success = RegisterHotKey(this.Handle, 407, 0, 76); // L 
            success = RegisterHotKey(this.Handle, 408, 0, 37);   // Left
            success = RegisterHotKey(this.Handle, 409, 0, 39);   // Right
            success = RegisterHotKey(this.Handle, 410, 0, 13);   // Enter
            success = RegisterHotKey(this.Handle, 411, 0, 27);   // ESC
        }

        private void initializeVLC()
        {
            vlc = new LibVlc();
            vlc.Initialize();
            vlc.VideoOutput = ekran;
            gEkran = vlc;
        }


        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewVideo_Load(object sender, EventArgs e)
        {
            chan_menu.Hide();
            InitializeWinLirc();

            GetEPG();

            flowControl1.Load("d:\\slike");
            
            vlc.PlaylistClear();
            vlc.AddTarget(AppSettings.RtmpAddress);
            vlc.Play(); 

            Size formrect = SystemInformation.PrimaryMonitorSize;
            //oi.Location = new Point((formrect.Height / 2)-(oi.Height/2), formrect.Width - oi.Width +70);

        }

        private void GetEPG()
        {
          /*  StreamReader sr = new StreamReader((new WebClient()).OpenRead(AppSettings.EpgAddress));
            do
            {
                line = sr.ReadLine();
                listbox1.Items.Add(line);
            }
            while (line != null);
            strm.Close(); */

            
        }

        private void InitializeWinLirc()
        {
            string addr = AppSettings.Addr;
            int port= Convert.ToInt32(AppSettings.Port);
            winLircControl.Connect(ref addr, ref port);
            winLircControl.ReceiveIR +=new AxWinLIRCClientControl.__WinLIRC_ReceiveIREventHandler(winLircControl_ReceiveIR);
       //     winLircControl.Error += new AxWinLIRCClientControl.__WinLIRC_ErrorEventHandler(winLircControl_Error);
        }

        private void winLircControl_Error(object sender, AxWinLIRCClientControl.__WinLIRC_ErrorEvent e)
        {
            MessageBox.Show("WinLirc Error: "+e.sErrDescription);
        }

        private void winLircControl_ReceiveIR(object sender, AxWinLIRCClientControl.__WinLIRC_ReceiveIREvent e)
        {
            switch (e.sRemote)
            {
                case "nextChan": break;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLocation ol = new OpenLocation();
            ol.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((openFileDialog1.OpenFile()) != null)
                {
                    vlc.Stop();
                    vlc.PlaylistClear();
                    vlc.AddTarget(openFileDialog1.FileName);
                    vlc.Play();
                }
            } 
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vlc.ToggleFullscreen();
        }

        private void remoteServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void channelInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // osd_Info.Visible = (osd_Info.Visible) ? false : true;
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nextChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
         /*  if (!Osd_ChanList.Visible)
                MessageBox.Show("Test Next Chan");
            else if (Osd_ChanList.SelectedIndex !=0)
                    Osd_ChanList.SelectedItem = Osd_ChanList.Items[Osd_ChanList.SelectedIndex - 1]; */
            vlc.PlaylistNext();
        }

        private void previuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vlc.PlaylistPrevious();
           /* if (!Osd_ChanList.Visible)
                MessageBox.Show("Test Prev Chan");
            else if (Osd_ChanList.SelectedIndex != Osd_ChanList.Items.Count-1)
                Osd_ChanList.SelectedItem = Osd_ChanList.Items[Osd_ChanList.SelectedIndex + 1]; */
        }

        private void rEcordToolStripMenuItem_Click(object sender, EventArgs e)
        {
       /*     if (info_Recording.Text == "R")
                info_Recording.Text = "";
            else info_Recording.Text = "R"; */
            
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vlc.VolumeMute();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DreamViewer\r\nby Teo Eterovic && Mladen Drmac");
        }


        private void isFullScreen_Tick(object sender, EventArgs e)
        {
            
 
        }

        private void ViewVideo_Activated(object sender, EventArgs e)
        {
            bool success = RegisterHotKey(this.Handle, 401, 0, 38);
            success = RegisterHotKey(this.Handle, 402, 0, 40);
            success = RegisterHotKey(this.Handle, 403, 0, 70);
            success = RegisterHotKey(this.Handle, 404, 0, 73);
            success = RegisterHotKey(this.Handle, 405, 0, 82);
            success = RegisterHotKey(this.Handle, 406, 0, 77);
            success = RegisterHotKey(this.Handle, 407, 0, 76);
            success = RegisterHotKey(this.Handle, 408, 0, 37);   // Left
            success = RegisterHotKey(this.Handle, 409, 0, 39);   // Right
            success = RegisterHotKey(this.Handle, 410, 0, 13);   // Enter
            success = RegisterHotKey(this.Handle, 411, 0, 27);   // ESC
        }

        private void ViewVideo_Deactivate(object sender, EventArgs e)
        {
            if (isFull())
            {
                bool full = true;
            }
            else
            {
                UnregisterHotKey(this.Handle, 401);
                UnregisterHotKey(this.Handle, 402);
                UnregisterHotKey(this.Handle, 403);
                UnregisterHotKey(this.Handle, 404);
                UnregisterHotKey(this.Handle, 405);
                UnregisterHotKey(this.Handle, 406);
                UnregisterHotKey(this.Handle, 407);
                UnregisterHotKey(this.Handle, 408);   // Left
                UnregisterHotKey(this.Handle, 409);   // Right
                UnregisterHotKey(this.Handle, 410);   // Enter
                UnregisterHotKey(this.Handle, 411);   // ESC
            }
        }

        private void ViewVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey(this.Handle, 401);
            UnregisterHotKey(this.Handle, 402);
            UnregisterHotKey(this.Handle, 403);
            UnregisterHotKey(this.Handle, 404);
            UnregisterHotKey(this.Handle, 405);
            UnregisterHotKey(this.Handle, 406);
            UnregisterHotKey(this.Handle, 407);
        }


        private void stopRecordSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "avi (*.avi)|*.avi|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                System.Diagnostics.Process vlcRecorder = new System.Diagnostics.Process();
                vlcRecorder.StartInfo.FileName = vlc.VlcInstallDir + "\\vlc.exe";
                vlcRecorder.StartInfo.Arguments = AppSettings.RtmpAddress+" --sout file/avi:" + saveFileDialog1.FileName;
                vlcRecorder.Start();
                MessageBox.Show("VLC media player is recording your stream(you can't watch the stream while recording !!)\nto stop recording close the VLC media player");
            }



        }

        private void wakeOnLanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WoLDialog w = new WoLDialog();
            w.Show();
        }

        private void channelListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chan_menu.Visible)
            {
                chan_menu.Hide();
            }
            else
            {
              //  Osd_ChanList.SelectedItem = Osd_ChanList.Items[0];
                chan_menu.Show();
            } 
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }


        private void winLircSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.WinLircSettingsDlg dlg = new VLCTestApp.Settings.WinLircSettingsDlg();
            dlg.Show();
        }

    }
}