using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VLCTestApp.Settings
{
    public partial class WinLircSettingsDlg : Form
    {
        private Settings appSettings;

        public WinLircSettingsDlg()
        {
            InitializeComponent();

            if (File.Exists("Settings.dat"))
            {
                FileStream fs;
                appSettings = (Settings)(new BinaryFormatter()).Deserialize(fs = File.Open("Settings.dat", FileMode.Open));
                fs.Close();
            }
            else
            {
                MessageBox.Show("Settngs file doesn't exists. Creating a new one");
                appSettings = new Settings();
            }

            rtmpURI.Text = appSettings.RtmpAddress;
            epgURI.Text = appSettings.EpgAddress;
            wlCm.Text = appSettings.Chan;
            wlFs.Text = appSettings.Full;
            wlNc.Text = appSettings.Next;
            wlPc.Text = appSettings.Prev;
            wlPort.Text = appSettings.Port;
            wlURI.Text = appSettings.Addr; 
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            appSettings.RtmpAddress = rtmpURI.Text;
            appSettings.EpgAddress = epgURI.Text;
            appSettings.Chan = wlCm.Text;
            appSettings.Full =wlFs.Text;
            appSettings.Next = wlNc.Text;
            appSettings.Prev = wlPc.Text;
            appSettings.Port = wlPort.Text;
            appSettings.Addr = wlURI.Text;

            FileStream fs;
            (new BinaryFormatter()).Serialize(fs=File.Open("Settings.dat", FileMode.Create), appSettings);
            fs.Close();
            this.Close();

        }
    }
}
