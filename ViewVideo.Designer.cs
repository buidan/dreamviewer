namespace VLCTestApp
{
    partial class ViewVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVideo));
            this.isFullScreen = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tEESSTTtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenNEt = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteControllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winLircSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.shutDownServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wakeOnLanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectViaVNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nextChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previuseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.rEcordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRecordSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.info_ChanName = new System.Windows.Forms.ToolStripStatusLabel();
            this.info_signalStraingth = new System.Windows.Forms.ToolStripProgressBar();
            this.info_Recording = new System.Windows.Forms.ToolStripStatusLabel();
            this.osd_Info = new System.Windows.Forms.Panel();
            this.osd_infoNext = new System.Windows.Forms.Label();
            this.osd_InfoChan = new System.Windows.Forms.Label();
            this.Osd_ChanList = new System.Windows.Forms.ListBox();
            this.ekran = new System.Windows.Forms.PictureBox();
            this.winLircControl = new AxWinLIRCClientControl.AxWinLIRC();
            this.contextMenuStrip1.SuspendLayout();
            this.VideoMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.osd_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLircControl)).BeginInit();
            this.SuspendLayout();
            // 
            // isFullScreen
            // 
            this.isFullScreen.Enabled = true;
            this.isFullScreen.Interval = 1000;
            this.isFullScreen.Tick += new System.EventHandler(this.isFullScreen_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEESSTTtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
            // 
            // tEESSTTtToolStripMenuItem
            // 
            this.tEESSTTtToolStripMenuItem.Name = "tEESSTTtToolStripMenuItem";
            this.tEESSTTtToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.tEESSTTtToolStripMenuItem.Text = "TEESSTTt";
            // 
            // VideoMenu
            // 
            this.VideoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.fullscreenStrip});
            this.VideoMenu.Name = "contextMenuStrip1";
            this.VideoMenu.Size = new System.Drawing.Size(173, 48);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // fullscreenStrip
            // 
            this.fullscreenStrip.Name = "fullscreenStrip";
            this.fullscreenStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fullscreenStrip.Size = new System.Drawing.Size(172, 22);
            this.fullscreenStrip.Text = "FullScreen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.controlToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 21);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenNEt,
            this.openFile,
            this.exit});
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 17);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenNEt
            // 
            this.OpenNEt.Name = "OpenNEt";
            this.OpenNEt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.OpenNEt.Size = new System.Drawing.Size(193, 22);
            this.OpenNEt.Text = "Open Network";
            this.OpenNEt.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(193, 22);
            this.openFile.Text = "Open File";
            this.openFile.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(193, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteServerToolStripMenuItem,
            this.remoteControllToolStripMenuItem,
            this.winLircSetupToolStripMenuItem,
            this.toolStripMenuItem3,
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(58, 17);
            this.optionsToolStripMenuItem.Text = "Settings";
            // 
            // remoteServerToolStripMenuItem
            // 
            this.remoteServerToolStripMenuItem.Name = "remoteServerToolStripMenuItem";
            this.remoteServerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.remoteServerToolStripMenuItem.Text = "Remote Server";
            this.remoteServerToolStripMenuItem.Click += new System.EventHandler(this.remoteServerToolStripMenuItem_Click);
            // 
            // remoteControllToolStripMenuItem
            // 
            this.remoteControllToolStripMenuItem.Name = "remoteControllToolStripMenuItem";
            this.remoteControllToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.remoteControllToolStripMenuItem.Text = "Remote Controll";
            // 
            // winLircSetupToolStripMenuItem
            // 
            this.winLircSetupToolStripMenuItem.Name = "winLircSetupToolStripMenuItem";
            this.winLircSetupToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.winLircSetupToolStripMenuItem.Text = "WinLirc Setup (local)";
            this.winLircSetupToolStripMenuItem.Click += new System.EventHandler(this.winLircSetupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(179, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.channelInfoToolStripMenuItem,
            this.channelListToolStripMenuItem,
            this.toolStripMenuItem2,
            this.shutDownServerToolStripMenuItem,
            this.wakeOnLanToolStripMenuItem,
            this.connectViaVNCToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(54, 17);
            this.controlToolStripMenuItem.Text = "Actions";
            this.controlToolStripMenuItem.Click += new System.EventHandler(this.controlToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.fullScreenToolStripMenuItem.Text = "FullScreen                [F]";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // channelInfoToolStripMenuItem
            // 
            this.channelInfoToolStripMenuItem.Name = "channelInfoToolStripMenuItem";
            this.channelInfoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.channelInfoToolStripMenuItem.Text = "Channel Info            [I]";
            this.channelInfoToolStripMenuItem.Click += new System.EventHandler(this.channelInfoToolStripMenuItem_Click);
            // 
            // channelListToolStripMenuItem
            // 
            this.channelListToolStripMenuItem.Name = "channelListToolStripMenuItem";
            this.channelListToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.channelListToolStripMenuItem.Text = "Channel List             [L]";
            this.channelListToolStripMenuItem.Click += new System.EventHandler(this.channelListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(223, 6);
            // 
            // shutDownServerToolStripMenuItem
            // 
            this.shutDownServerToolStripMenuItem.Name = "shutDownServerToolStripMenuItem";
            this.shutDownServerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.S)));
            this.shutDownServerToolStripMenuItem.ShowShortcutKeys = false;
            this.shutDownServerToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.shutDownServerToolStripMenuItem.Text = "ShutDown Server     [Ctrl+Alt+S]";
            this.shutDownServerToolStripMenuItem.Click += new System.EventHandler(this.shutDownServerToolStripMenuItem_Click);
            // 
            // wakeOnLanToolStripMenuItem
            // 
            this.wakeOnLanToolStripMenuItem.Name = "wakeOnLanToolStripMenuItem";
            this.wakeOnLanToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.wakeOnLanToolStripMenuItem.Text = "WakeOnLan";
            this.wakeOnLanToolStripMenuItem.Click += new System.EventHandler(this.wakeOnLanToolStripMenuItem_Click);
            // 
            // connectViaVNCToolStripMenuItem
            // 
            this.connectViaVNCToolStripMenuItem.Name = "connectViaVNCToolStripMenuItem";
            this.connectViaVNCToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.connectViaVNCToolStripMenuItem.Text = "Connect via VNC";
            // 
            // controlToolStripMenuItem1
            // 
            this.controlToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextChannelToolStripMenuItem,
            this.previuseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.rEcordToolStripMenuItem,
            this.stopRecordSToolStripMenuItem,
            this.toolStripMenuItem4,
            this.muteToolStripMenuItem});
            this.controlToolStripMenuItem1.Name = "controlToolStripMenuItem1";
            this.controlToolStripMenuItem1.Size = new System.Drawing.Size(54, 17);
            this.controlToolStripMenuItem1.Text = "Control";
            // 
            // nextChannelToolStripMenuItem
            // 
            this.nextChannelToolStripMenuItem.Name = "nextChannelToolStripMenuItem";
            this.nextChannelToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.nextChannelToolStripMenuItem.Text = "Up Channel                  [Up]";
            this.nextChannelToolStripMenuItem.Click += new System.EventHandler(this.nextChannelToolStripMenuItem_Click);
            // 
            // previuseToolStripMenuItem
            // 
            this.previuseToolStripMenuItem.Name = "previuseToolStripMenuItem";
            this.previuseToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.previuseToolStripMenuItem.Text = "Down Channel             [Down]";
            this.previuseToolStripMenuItem.Click += new System.EventHandler(this.previuseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // rEcordToolStripMenuItem
            // 
            this.rEcordToolStripMenuItem.Name = "rEcordToolStripMenuItem";
            this.rEcordToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.rEcordToolStripMenuItem.Text = "Record (On Server can watch)     [R]";
            this.rEcordToolStripMenuItem.Click += new System.EventHandler(this.rEcordToolStripMenuItem_Click);
            // 
            // stopRecordSToolStripMenuItem
            // 
            this.stopRecordSToolStripMenuItem.Name = "stopRecordSToolStripMenuItem";
            this.stopRecordSToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.stopRecordSToolStripMenuItem.Text = "Record Local";
            this.stopRecordSToolStripMenuItem.Click += new System.EventHandler(this.stopRecordSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(258, 6);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.muteToolStripMenuItem.Text = "Mute                            [M]";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 17);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info_Time,
            this.info_ChanName,
            this.info_signalStraingth,
            this.info_Recording});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // info_Time
            // 
            this.info_Time.BackColor = System.Drawing.SystemColors.Control;
            this.info_Time.Name = "info_Time";
            this.info_Time.Size = new System.Drawing.Size(35, 17);
            this.info_Time.Text = "22:00";
            // 
            // info_ChanName
            // 
            this.info_ChanName.BackColor = System.Drawing.SystemColors.Control;
            this.info_ChanName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.info_ChanName.Name = "info_ChanName";
            this.info_ChanName.Size = new System.Drawing.Size(332, 17);
            this.info_ChanName.Spring = true;
            this.info_ChanName.Text = "ProSieben";
            // 
            // info_signalStraingth
            // 
            this.info_signalStraingth.Name = "info_signalStraingth";
            this.info_signalStraingth.Size = new System.Drawing.Size(100, 16);
            this.info_signalStraingth.Value = 40;
            // 
            // info_Recording
            // 
            this.info_Recording.BackColor = System.Drawing.SystemColors.Control;
            this.info_Recording.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_Recording.ForeColor = System.Drawing.Color.Red;
            this.info_Recording.Name = "info_Recording";
            this.info_Recording.Size = new System.Drawing.Size(0, 17);
            // 
            // osd_Info
            // 
            this.osd_Info.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.osd_Info.BackColor = System.Drawing.Color.Black;
            this.osd_Info.Controls.Add(this.osd_infoNext);
            this.osd_Info.Controls.Add(this.osd_InfoChan);
            this.osd_Info.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.osd_Info.Location = new System.Drawing.Point(15, 301);
            this.osd_Info.Name = "osd_Info";
            this.osd_Info.Size = new System.Drawing.Size(455, 80);
            this.osd_Info.TabIndex = 0;
            this.osd_Info.Visible = false;
            // 
            // osd_infoNext
            // 
            this.osd_infoNext.AutoSize = true;
            this.osd_infoNext.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osd_infoNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.osd_infoNext.Location = new System.Drawing.Point(13, 35);
            this.osd_infoNext.Name = "osd_infoNext";
            this.osd_infoNext.Size = new System.Drawing.Size(156, 36);
            this.osd_infoNext.TabIndex = 1;
            this.osd_infoNext.Text = "22:00 Focus TV\r\n23:45 Hepek Drot";
            // 
            // osd_InfoChan
            // 
            this.osd_InfoChan.AutoSize = true;
            this.osd_InfoChan.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osd_InfoChan.ForeColor = System.Drawing.Color.Transparent;
            this.osd_InfoChan.Location = new System.Drawing.Point(9, 3);
            this.osd_InfoChan.Name = "osd_InfoChan";
            this.osd_InfoChan.Size = new System.Drawing.Size(150, 29);
            this.osd_InfoChan.TabIndex = 0;
            this.osd_InfoChan.Text = "ProSieben";
            // 
            // Osd_ChanList
            // 
            this.Osd_ChanList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Osd_ChanList.BackColor = System.Drawing.Color.DimGray;
            this.Osd_ChanList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Osd_ChanList.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Osd_ChanList.ForeColor = System.Drawing.Color.White;
            this.Osd_ChanList.FormattingEnabled = true;
            this.Osd_ChanList.ItemHeight = 18;
            this.Osd_ChanList.Items.AddRange(new object[] {
            "PRemiere",
            "Kabel1",
            "PremiereWorld"});
            this.Osd_ChanList.Location = new System.Drawing.Point(62, 47);
            this.Osd_ChanList.Name = "Osd_ChanList";
            this.Osd_ChanList.Size = new System.Drawing.Size(334, 306);
            this.Osd_ChanList.TabIndex = 38;
            this.Osd_ChanList.Visible = false;
            // 
            // ekran
            // 
            this.ekran.BackColor = System.Drawing.Color.White;
            this.ekran.BackgroundImage = global::VLCTestApp.Properties.Resources.dreamlogo;
            this.ekran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ekran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ekran.Location = new System.Drawing.Point(0, 0);
            this.ekran.Name = "ekran";
            this.ekran.Size = new System.Drawing.Size(484, 409);
            this.ekran.TabIndex = 42;
            this.ekran.TabStop = false;
            // 
            // winLircControl
            // 
            this.winLircControl.Enabled = true;
            this.winLircControl.Location = new System.Drawing.Point(439, 0);
            this.winLircControl.Name = "winLircControl";
            this.winLircControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winLircControl.OcxState")));
            this.winLircControl.Size = new System.Drawing.Size(45, 45);
            this.winLircControl.TabIndex = 44;
            // 
            // ViewVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 409);
            this.Controls.Add(this.winLircControl);
            this.Controls.Add(this.Osd_ChanList);
            this.Controls.Add(this.osd_Info);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ekran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DreamViewer - Connecting to Server";
            this.Deactivate += new System.EventHandler(this.ViewVideo_Deactivate);
            this.Load += new System.EventHandler(this.ViewVideo_Load);
            this.Activated += new System.EventHandler(this.ViewVideo_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewVideo_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.VideoMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.osd_Info.ResumeLayout(false);
            this.osd_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winLircControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Timer isFullScreen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip VideoMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenNEt;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem remoteServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteControllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tEESSTTtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel info_Time;
        private System.Windows.Forms.ToolStripStatusLabel info_ChanName;
        private System.Windows.Forms.ToolStripProgressBar info_signalStraingth;
        private System.Windows.Forms.Panel osd_Info;
        private System.Windows.Forms.Label osd_infoNext;
        private System.Windows.Forms.Label osd_InfoChan;
        private System.Windows.Forms.ToolStripMenuItem channelInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nextChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previuseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rEcordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel info_Recording;
        private System.Windows.Forms.ToolStripMenuItem shutDownServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem wakeOnLanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winLircSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectViaVNCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem channelListToolStripMenuItem;
        private System.Windows.Forms.ListBox Osd_ChanList;
        private System.Windows.Forms.PictureBox ekran;
        private AxWinLIRCClientControl.AxWinLIRC winLircControl;
    }
}