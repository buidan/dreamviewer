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


namespace VLCTestApp
{
    public partial class ViewVideo : Form
    {
        private static LibVlc vlc;
        private OSD.OSDInfo oi;
        private CodeProject.SystemHotkey.SystemHotkey sH_osdInfo;


        // Net :)
        private Socket client;
        private byte[] data = new byte[1024];
        private int size = 1024;

        public static LibVlc gEkran
        {
            get { return vlc; }
            set { vlc = value; }
        }

        private void shOSDInfo_Pressed(object sender, System.EventArgs e)
        {
            MessageBox.Show("OK");
        }

        void Connected(IAsyncResult iar)
        {
            client = (Socket)iar.AsyncState;
            try
            {
                client.EndConnect(iar);
                this.Invoke(new MethodInvoker( delegate() {
                    Text = "DreamViever Connected:" + client.RemoteEndPoint.ToString(); }));
                client.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), client);
            }
            catch (SocketException)
            {
                MessageBox.Show("Error connecting to DvbDream");
            }
        }

        void ReceiveData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            string[] kom = stringData.Split(Convert.ToChar(35));
            if (kom[0] == "set")
                switch (kom[1])
                {
                    case "chaninfo":
                        this.Invoke(new MethodInvoker(delegate()
                        { 
                            osd_InfoChan.Text = kom[2];
                            osd_infoNext.Text = kom[3] + Environment.NewLine + kom[4];
                            osd_Info.Show();
                        }));
                        break;
                    case "signal":
                        this.Invoke(new MethodInvoker(delegate()
                        {
                            info_signalStraingth.Value = Convert.ToInt32(kom[2]);
                        }));
                        break;
                }

            remote.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), remote);
        }

        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
            remote.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), remote);
        }


        public ViewVideo()
        {
            InitializeComponent();
            vlc = new LibVlc();
            vlc.Initialize();
            vlc.VideoOutput = ekran;

            gEkran = vlc;

            // inicializiraj OSD
            oi = new OSD.OSDInfo();

            // REgistruj
            this.sH_osdInfo = new CodeProject.SystemHotkey.SystemHotkey(this.components);
            this.sH_osdInfo.Shortcut = System.Windows.Forms.Shortcut.AltF6;
            this.sH_osdInfo.Pressed += new System.EventHandler(this.shOSDInfo_Pressed);
        }


        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewVideo_Load(object sender, EventArgs e)
        {
            vlc.PlaylistClear();
            vlc.AddTarget("udp://@");
            
            vlc.Play();
            Size formrect = SystemInformation.PrimaryMonitorSize;
            //oi.Location = new Point((formrect.Height / 2)-(oi.Height/2), formrect.Width - oi.Width +70);

            // Connect to server
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("10.1.1.2"), 2000);
            newsock.BeginConnect(iep, new AsyncCallback(Connected), newsock);
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLink ol = new OpenLink();
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
            oi.Show();
        }

        private void channelInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.BeginSend(Encoding.ASCII.GetBytes("get chaninfo"), 0, 12, SocketFlags.None,new AsyncCallback(SendData), client);
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nextChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.BeginSend(Encoding.ASCII.GetBytes("rmt d"), 0, 5, SocketFlags.None, new AsyncCallback(SendData), client);
        }

        private void previuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.BeginSend(Encoding.ASCII.GetBytes("rmt e"), 0, 5, SocketFlags.None, new AsyncCallback(SendData), client);
        }

        private void rEcordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (info_Recording.Text == "R")
                info_Recording.Text = "";
            else info_Recording.Text = "R";
            client.BeginSend(Encoding.ASCII.GetBytes("rmt 12"), 0, 6, SocketFlags.None, new AsyncCallback(SendData), client);
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.BeginSend(Encoding.ASCII.GetBytes("rmt 2"), 0, 5, SocketFlags.None, new AsyncCallback(SendData), client);
        }

        private void shutDownServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.BeginSend(Encoding.ASCII.GetBytes("rmt 1"), 0, 5, SocketFlags.None, new AsyncCallback(SendData), client);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DreamViewer\r\nby Teo Eterovic");
        }

    }
}