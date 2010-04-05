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
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.winLircSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaStramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.wakeOnLanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nextChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previuseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.stopRecordSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winLircControl = new AxWinLIRCClientControl.AxWinLIRC();
            this.label1 = new System.Windows.Forms.Label();
            this.ekran = new System.Windows.Forms.PictureBox();
            this.chan_menu = new System.Windows.Forms.Integration.ElementHost();
            this.flowControl1 = new Ded.Tutorial.Wpf.CoverFlow.Part5.FlowComponent.FlowControl();
            this.contextMenuStrip1.SuspendLayout();
            this.VideoMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winLircControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).BeginInit();
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
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.controlToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 23);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenNEt,
            this.openFile,
            this.toolStripMenuItem3,
            this.winLircSettingsToolStripMenuItem,
            this.toolStripMenuItem5,
            this.exit});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 6);
            // 
            // winLircSettingsToolStripMenuItem
            // 
            this.winLircSettingsToolStripMenuItem.Name = "winLircSettingsToolStripMenuItem";
            this.winLircSettingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.winLircSettingsToolStripMenuItem.Text = "Settings";
            this.winLircSettingsToolStripMenuItem.Click += new System.EventHandler(this.winLircSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(190, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(193, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.channelListToolStripMenuItem,
            this.mediaStramsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.wakeOnLanToolStripMenuItem});
            this.controlToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(54, 17);
            this.controlToolStripMenuItem.Text = "Actions";
            this.controlToolStripMenuItem.Click += new System.EventHandler(this.controlToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.fullScreenToolStripMenuItem.Text = "FullScreen                [F]";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // channelListToolStripMenuItem
            // 
            this.channelListToolStripMenuItem.Name = "channelListToolStripMenuItem";
            this.channelListToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.channelListToolStripMenuItem.Text = "Channel List             [L]";
            this.channelListToolStripMenuItem.Click += new System.EventHandler(this.channelListToolStripMenuItem_Click);
            // 
            // mediaStramsToolStripMenuItem
            // 
            this.mediaStramsToolStripMenuItem.Name = "mediaStramsToolStripMenuItem";
            this.mediaStramsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mediaStramsToolStripMenuItem.Text = "Media Streams         [M]";
            this.mediaStramsToolStripMenuItem.Click += new System.EventHandler(this.mediaStramsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 6);
            // 
            // wakeOnLanToolStripMenuItem
            // 
            this.wakeOnLanToolStripMenuItem.Name = "wakeOnLanToolStripMenuItem";
            this.wakeOnLanToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.wakeOnLanToolStripMenuItem.Text = "WakeOnLan";
            this.wakeOnLanToolStripMenuItem.Click += new System.EventHandler(this.wakeOnLanToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem1
            // 
            this.controlToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextChannelToolStripMenuItem,
            this.previuseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.stopRecordSToolStripMenuItem,
            this.toolStripMenuItem4,
            this.muteToolStripMenuItem});
            this.controlToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.controlToolStripMenuItem1.Name = "controlToolStripMenuItem1";
            this.controlToolStripMenuItem1.Size = new System.Drawing.Size(54, 17);
            this.controlToolStripMenuItem1.Text = "Control";
            // 
            // nextChannelToolStripMenuItem
            // 
            this.nextChannelToolStripMenuItem.Name = "nextChannelToolStripMenuItem";
            this.nextChannelToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.nextChannelToolStripMenuItem.Text = "Up Channel                  [Up]";
            this.nextChannelToolStripMenuItem.Click += new System.EventHandler(this.nextChannelToolStripMenuItem_Click);
            // 
            // previuseToolStripMenuItem
            // 
            this.previuseToolStripMenuItem.Name = "previuseToolStripMenuItem";
            this.previuseToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.previuseToolStripMenuItem.Text = "Down Channel             [Down]";
            this.previuseToolStripMenuItem.Click += new System.EventHandler(this.previuseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // stopRecordSToolStripMenuItem
            // 
            this.stopRecordSToolStripMenuItem.Name = "stopRecordSToolStripMenuItem";
            this.stopRecordSToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.stopRecordSToolStripMenuItem.Text = "Record Local";
            this.stopRecordSToolStripMenuItem.Click += new System.EventHandler(this.stopRecordSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(225, 6);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.muteToolStripMenuItem.Text = "Mute                            [M]";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 17);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // winLircControl
            // 
            this.winLircControl.Enabled = true;
            this.winLircControl.Location = new System.Drawing.Point(514, 0);
            this.winLircControl.Name = "winLircControl";
            this.winLircControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winLircControl.OcxState")));
            this.winLircControl.Size = new System.Drawing.Size(45, 45);
            this.winLircControl.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(379, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Copyright Teo & Mladen";
            // 
            // ekran
            // 
            this.ekran.BackColor = System.Drawing.Color.Black;
            this.ekran.BackgroundImage = global::VLCTestApp.Properties.Resources.dreamlogo;
            this.ekran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ekran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ekran.Location = new System.Drawing.Point(0, 0);
            this.ekran.Name = "ekran";
            this.ekran.Size = new System.Drawing.Size(564, 461);
            this.ekran.TabIndex = 42;
            this.ekran.TabStop = false;
            // 
            // chan_menu
            // 
            this.chan_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chan_menu.Location = new System.Drawing.Point(0, 23);
            this.chan_menu.Name = "chan_menu";
            this.chan_menu.Size = new System.Drawing.Size(564, 438);
            this.chan_menu.TabIndex = 46;
            this.chan_menu.Text = "chan_menu";
            this.chan_menu.Child = this.flowControl1;
            // 
            // ViewVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(564, 461);
            this.Controls.Add(this.winLircControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chan_menu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ekran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DreamViewer";
            this.Deactivate += new System.EventHandler(this.ViewVideo_Deactivate);
            this.Load += new System.EventHandler(this.ViewVideo_Load);
            this.Activated += new System.EventHandler(this.ViewVideo_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewVideo_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.VideoMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winLircControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tEESSTTtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nextChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previuseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem wakeOnLanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem channelListToolStripMenuItem;
        private System.Windows.Forms.PictureBox ekran;
        private AxWinLIRCClientControl.AxWinLIRC winLircControl;
        private System.Windows.Forms.Integration.ElementHost chan_menu;
        private Ded.Tutorial.Wpf.CoverFlow.Part5.FlowComponent.FlowControl flowControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem winLircSettingsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mediaStramsToolStripMenuItem;

    }
}