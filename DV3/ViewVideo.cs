using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using UsbLibrary;
using System.Xml;
using System.Collections;


namespace VLCTestApp {
    public partial class ViewVideo : Form {

        #region hotkey
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ShowWindow(IntPtr hWnd, int showcmd);


        private OSD.OSDChanList oc;
        private OSD.OSDInfo oi;
        private Settings.Settings AppSettings;

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x0312)
                switch ((int)m.WParam) {
                    case 401: nextChannelToolStripMenuItem_Click(this, null); break;
                    case 402: previuseToolStripMenuItem_Click(this, null); break;
                    case 403: /*vlc.ToggleFullscreen();*/ break;
                    case 404:
                        if (!isFull()) {
                            channelInfoToolStripMenuItem_Click(this, null);
                        }
                        else {
                            if (oi == null) oi = new OSD.OSDInfo();
                            if (!oi.Visible) oi.Show(); else oi.Hide();
                        }
                        break;
                    //  if (!full) channelInfoToolStripMenuItem_Click(this, null); break;
                    // case 405: rEcordToolStripMenuItem_Click(this, null); break;
                    case 405: MessageBox.Show(isFull().ToString()); break;
                  //  case 406: muteToolStripMenuItem_Click(this, null); break;
                    case 406: mediaStramsToolStripMenuItem_Click(this, null); break;
                    case 407:
                        videoOnDemandList();
                        break;
                    case 408:
                        flowPrevious();
                        break;
                    case 409:
                        flowNext();
                        break;
                    case 410:
                        flowOK();
                        break;
                    case 411: /*if (isFull()) { if (oc != null && oc.Visible) oc.Hide(); else vlc.ToggleFullscreen(); }*/ break;
                    case 412: vlc.Pause(); break;
                }
            usb.ParseMessages(ref m);
            base.WndProc(ref m);
        }
        private void USBremoteDataRecived(string rec_data) {
            if (rec_data.Contains("001 0")) this.Close();
            if (rec_data.Contains("6")) vlc.ToggleFullscreen();
            if (rec_data.Contains("8")) flowPrevious();
            if (rec_data.Contains("010 0")) flowNext();
            if (rec_data.Contains("9")) flowOK();
            if (rec_data.Contains("5")) videoOnDemandList();
        }
        #endregion

        private bool isFull() {
            StringBuilder Buff = new StringBuilder(256);
            if (GetWindowText(GetForegroundWindow(), Buff, 256) > 0)
                if (Buff.ToString() == "VLC (hardware YUV overlay DirectX output)")
                    return true;
            return false;
        }

        private bool chanLoaded = false, iptvLoaded=false;
        private static LibVlc vlc;

        private byte[] data = new byte[1024];
        private UsbHidPort usb = new UsbHidPort();
        private ArrayList videostore;
        private bool isIPTV = false;

        public static LibVlc gEkran {
            get { return vlc; }
            set { vlc = value; }
        }

        public void nextChan() {
            nextChannelToolStripMenuItem_Click(this, null);
        }
        public void prevChan() {
            previuseToolStripMenuItem_Click(this, null);
        }

        public ViewVideo() {
            InitializeComponent();
            loadSettings();
            initializeVLC();
            initializHotKeys();

            //Uklanja plavi okvir oko forme, setuje formu tako da bude preko citavog ekrana
            //FormWindowState.Maximized je pravio problem pa sam rucno setovao formu da prekrije cijeli monitor
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void loadSettings() {
            if (File.Exists("Settings.dat")) {
                FileStream fs;
                AppSettings = (Settings.Settings)(new BinaryFormatter()).Deserialize(fs = File.Open("Settings.dat", FileMode.Open));
                fs.Close();
            }
            else MessageBox.Show("Settngs file doesn't exists");
        }

        private void OpenStream(string stream) {
            vlc.Stop();
            vlc.PlaylistClear();
            vlc.AddTarget(stream);
            vlc.Play();

            if (isFull()) oc.Hide(); else chan_menu.Hide();
            isIPTV = false;
        }
        private void initializHotKeys() {
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
            success = RegisterHotKey(this.Handle, 412, 0, 32);   //Space
        }

        private void initializeVLC() {
            vlc = new LibVlc();
            vlc.Initialize();
            vlc.VideoOutput = ekran;
            gEkran = vlc;
        }


        private void flowPrevious() {
            if (isIPTV) 
                flowControl2.GoToPrevious();
            else flowControl1.GoToPrevious();
        }
        private void flowNext() {
            if (isIPTV) 
                flowControl2.GoToNext();
            else flowControl1.GoToNext(); 
        }
        private void videoOnDemandList() {
            if (!isFull()) {
                channelListToolStripMenuItem_Click(this, null);
            }
            else {
                vlc.Stop();
                if (oc == null) oc = new OSD.OSDChanList();
                if (!oc.Visible) oc.Show(); else oc.Hide();
            }
        }
        private void btnSchliessen_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ViewVideo_Load(object sender, EventArgs e) {
            GetEPG();
            chan_menu.Hide();
            iptv_menu.Hide();

            vlc.PlaylistClear();
            vlc.AddTarget(AppSettings.RtmpAddress);
            vlc.Play();

            initializeRemote();

            Size formrect = SystemInformation.PrimaryMonitorSize;
            //oi.Location = new Point((formrect.Height / 2)-(oi.Height/2), formrect.Width - oi.Width +70);

        }

        private void initializeRemote() {
            try {
                this.usb.ProductId = Int32.Parse("CC00", System.Globalization.NumberStyles.HexNumber);
                this.usb.VendorId = Int32.Parse("1130", System.Globalization.NumberStyles.HexNumber);

                this.usb.OnSpecifiedDeviceRemoved += new System.EventHandler(this.usb_OnSpecifiedDeviceRemoved);
                this.usb.OnDeviceArrived += new System.EventHandler(this.usb_OnDeviceArrived);
                this.usb.OnDeviceRemoved += new System.EventHandler(this.usb_OnDeviceRemoved);
                this.usb.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(this.usb_OnDataRecieved);
                this.usb.OnSpecifiedDeviceArrived += new System.EventHandler(this.usb_OnSpecifiedDeviceArrived);
                //    this.usb.OnDataSend += new System.EventHandler(this.usb_OnDataSend);

                this.usb.CheckDevicePresent();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void usb_OnDeviceArrived(object sender, EventArgs e) {
            System.Console.WriteLine("Found a Device");
        }

        private void usb_OnDeviceRemoved(object sender, EventArgs e) {
            if (InvokeRequired) {
                Invoke(new EventHandler(usb_OnDeviceRemoved), new object[] { sender, e });
            }
            else {
                System.Console.WriteLine("Device was removed");
            }
        }

        private void usb_OnSpecifiedDeviceRemoved(object sender, EventArgs e) {
            if (InvokeRequired) {
                Invoke(new EventHandler(usb_OnSpecifiedDeviceRemoved), new object[] { sender, e });
            }
            else {
                System.Console.WriteLine("My device was removed");
            }
        }

        private void usb_OnDataRecieved(object sender, DataRecievedEventArgs args) {
            if (InvokeRequired) {
                try {
                    Invoke(new DataRecievedEventHandler(usb_OnDataRecieved), new object[] { sender, args });
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
            }
            else {

                string rec_data = "Data: ";
                foreach (byte myData in args.data) {
                    if (myData.ToString().Length == 1) {
                        rec_data += "00";
                    }

                    if (myData.ToString().Length == 2) {
                        rec_data += "0";
                    }

                    rec_data += myData.ToString() + " ";
                }

                USBremoteDataRecived(rec_data);
            }
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            usb.RegisterHandle(Handle);
        }


        private void usb_OnSpecifiedDeviceArrived(object sender, EventArgs e) {
            System.Console.WriteLine("My device was found");

            //setting string form for sending data
            string text = "";
            for (int i = 0; i < this.usb.SpecifiedDevice.OutputReportLength - 1; i++) {
                text += "000 ";
            }
        }

        private class Video {
            private int id;
            private string name;

            public Video(int i, string n) {
                name = n;
                id = i;
            }

            public string getID() {
                return id.ToString();
            }
        }

        private void GetEPG() {
            try {
                videostore = new ArrayList();
                int last = 0;
                string name = "";

                XmlTextReader reader = new XmlTextReader(AppSettings.RtmpAddress + "/servis.php");
                while (reader.Read()) {
                    switch (reader.NodeType) {
                        case XmlNodeType.Element: // The node is an element.
                            if (reader.Name == "name") last = 1; else last = 2;
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            if (last == 1) {
                                name = reader.Value;
                            }
                            if (last == 2) {
                                videostore.Add(new Video(Convert.ToInt32(reader.Value), name));
                            }
                            break;
                    }
                }

                if (!Directory.Exists("cache")) {
                    Directory.CreateDirectory("cache");
                }
                else {
                    string[] filenames = Directory.GetFiles("cache");
                    foreach (string filename in filenames) {
                        File.Delete(filename);
                    }

                    filenames = Directory.GetFiles("cache\\tn");
                    foreach (string filename in filenames)
                    {
                        File.Delete(filename);
                    }
                }
                //Ne radi kad je folder pod SVN-om, imas access denied kad brises temp folder
                //if (Directory.Exists("cache")) {
                //    if (Directory.Exists("temp")) Directory.GDelete("temp", true);
                //    Directory.Move("cache", "temp");
                //}
                //Directory.CreateDirectory("cache");

                WebClient Client = new WebClient();

                foreach (Video v in videostore) {
                    Client.DownloadFile(AppSettings.RtmpAddress + "/cover/" + v.getID() + ".jpg", "cache\\" + v.getID() + ".jpg");
                }
            }
            catch (Exception e) {
                MessageBox.Show("Get VoD error: " + e.Message);
            }


            /*  try
              {
                  if (Directory.Exists("cache"))
                  {
                      if (Directory.Exists("temp")) Directory.Delete("temp", true);
                      Directory.Move("cache", "temp");
                  }
                  Directory.CreateDirectory("cache");
                  StreamReader sr = new StreamReader((new WebClient()).OpenRead(AppSettings.EpgAddress));
                  string line;
                  while ((line = sr.ReadLine()) != null)
                  {
                      if (line.StartsWith("\""))
                      {
                          string[] part = line.Split('\\');
                          string video = part[part.Length - 1].Split('\"')[0];

                          if (File.Exists("temp\\" + video + ".jpg"))
                          {
                              File.Move("temp\\" + video + ".jpg", "cache\\" + video + ".jpg");
                          }
                          else
                          {
                              System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(vlc.VlcInstallDir + "\\vlc.exe");
                              startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                              startInfo.Arguments = "-V image --start-time 0 --stop-time 1 --image-out-format jpg --image-out-ratio 24 --image-out-prefix cache/" + video + " --image-out-replace rtsp://127.0.0.1/" + video + " vlc:quit";
                              Process.Start(startInfo);
                          }
                      }
                  }
                  sr.Close();
              }
              catch (Exception e) { MessageBox.Show(e.Message); } */


        }






        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenLocation ol = new OpenLocation();
            ol.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                if ((openFileDialog1.OpenFile()) != null) {
                    vlc.Stop();
                    vlc.PlaylistClear();
                    vlc.AddTarget(openFileDialog1.FileName);
                    vlc.Play();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e) {
            vlc.ToggleFullscreen();
        }

        private void remoteServerToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void channelInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            // osd_Info.Visible = (osd_Info.Visible) ? false : true;
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void nextChannelToolStripMenuItem_Click(object sender, EventArgs e) {
            /*  if (!Osd_ChanList.Visible)
                   MessageBox.Show("Test Next Chan");
               else if (Osd_ChanList.SelectedIndex !=0)
                       Osd_ChanList.SelectedItem = Osd_ChanList.Items[Osd_ChanList.SelectedIndex - 1]; */
            vlc.PlaylistNext();
        }

        private void previuseToolStripMenuItem_Click(object sender, EventArgs e) {
            vlc.PlaylistPrevious();
            /* if (!Osd_ChanList.Visible)
                 MessageBox.Show("Test Prev Chan");
             else if (Osd_ChanList.SelectedIndex != Osd_ChanList.Items.Count-1)
                 Osd_ChanList.SelectedItem = Osd_ChanList.Items[Osd_ChanList.SelectedIndex + 1]; */
        }

        private void rEcordToolStripMenuItem_Click(object sender, EventArgs e) {
            /*     if (info_Recording.Text == "R")
                     info_Recording.Text = "";
                 else info_Recording.Text = "R"; */

        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e) {
            vlc.VolumeMute();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("DreamViewer\r\nby Teo Eterovic");
        }


        private void isFullScreen_Tick(object sender, EventArgs e) {


        }

        private void ViewVideo_Activated(object sender, EventArgs e) {
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
            success = RegisterHotKey(this.Handle, 412, 0, 32);   //Space
        }

        private void ViewVideo_Deactivate(object sender, EventArgs e) {
            if (isFull()) {
                bool full = true;
            }
            else {
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
                UnregisterHotKey(this.Handle, 412);   // Space
            }
        }

        private void ViewVideo_FormClosed(object sender, FormClosedEventArgs e) {
            UnregisterHotKey(this.Handle, 401);
            UnregisterHotKey(this.Handle, 402);
            UnregisterHotKey(this.Handle, 403);
            UnregisterHotKey(this.Handle, 404);
            UnregisterHotKey(this.Handle, 405);
            UnregisterHotKey(this.Handle, 406);
            UnregisterHotKey(this.Handle, 407);
        }


        private void stopRecordSToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "avi (*.avi)|*.avi|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                System.Diagnostics.Process vlcRecorder = new System.Diagnostics.Process();
                vlcRecorder.StartInfo.FileName = vlc.VlcInstallDir + "\\vlc.exe";
                vlcRecorder.StartInfo.Arguments = AppSettings.RtmpAddress + " --sout file/avi:" + saveFileDialog1.FileName;
                vlcRecorder.Start();
                MessageBox.Show("VLC media player is recording your stream(you can't watch the stream while recording !!)\nto stop recording close the VLC media player");
            }



        }

        private void wakeOnLanToolStripMenuItem_Click(object sender, EventArgs e) {
            WoLDialog w = new WoLDialog();
            w.Show();
        }

        private void channelListToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!chanLoaded) { flowControl1.Load("cache", "*.jpg"); chanLoaded = true; }
            if (chan_menu.Visible) {
                chan_menu.Hide();
            }
            else {
                //  Osd_ChanList.SelectedItem = Osd_ChanList.Items[0];
                chan_menu.Show();
            }
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Test");
        }


        private void winLircSettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            Settings.WinLircSettingsDlg dlg = new VLCTestApp.Settings.WinLircSettingsDlg();
            dlg.Show();
        }

        private void flowOK() {
            try {
                if (iptv_menu.Visible)
                {
                    string loc = flowControl2.GetCurrImage();
                    OpenStream("udp://@" + loc + ":5000");
                }
                if (chan_menu.Visible || oc.Visible) {
                    string loc = (isFull())
                         ? OSD.OSDChanList.flowControl1.GetCurrImage()
                         : flowControl1.GetCurrImage();
                       
                    OpenStream(AppSettings.RtmpAddress + "/movie/" + loc + ".film");
                }
            }
            catch (Exception) { }
        }
        private void mediaStramsToolStripMenuItem_Click(object sender, EventArgs e) {

            //OpenStream(AppSettings.RtmpAddress);
            if (!iptvLoaded) { flowControl2.Load("chan_cache", "*.png"); iptvLoaded = true; }
            if (iptv_menu.Visible)
            {
                isIPTV = false;
                iptv_menu.Hide();
            }
            else
            {
                //  Osd_ChanList.SelectedItem = Osd_ChanList.Items[0];
                isIPTV = true;
                iptv_menu.Show();
            }
        }
    }
}