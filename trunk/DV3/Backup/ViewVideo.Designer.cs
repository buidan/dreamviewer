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
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.info_ChanName = new System.Windows.Forms.ToolStripStatusLabel();
            this.info_signalStraingth = new System.Windows.Forms.ToolStripProgressBar();
            this.osd_Info = new System.Windows.Forms.Panel();
            this.osd_infoNext = new System.Windows.Forms.Label();
            this.osd_InfoChan = new System.Windows.Forms.Label();
            this.ekran = new System.Windows.Forms.PictureBox();
            this.channelInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nextChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previuseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.rEcordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_Recording = new System.Windows.Forms.ToolStripStatusLabel();
            this.shutDownServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.VideoMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.osd_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekran)).BeginInit();
            this.SuspendLayout();
            // 
            // isFullScreen
            // 
            this.isFullScreen.Enabled = true;
            this.isFullScreen.Interval = 1000;
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
            this.menuStrip1.Size = new System.Drawing.Size(479, 21);
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
            this.remoteControllToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(58, 17);
            this.optionsToolStripMenuItem.Text = "Settings";
            // 
            // remoteServerToolStripMenuItem
            // 
            this.remoteServerToolStripMenuItem.Name = "remoteServerToolStripMenuItem";
            this.remoteServerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.remoteServerToolStripMenuItem.Text = "Remote Server";
            this.remoteServerToolStripMenuItem.Click += new System.EventHandler(this.remoteServerToolStripMenuItem_Click);
            // 
            // remoteControllToolStripMenuItem
            // 
            this.remoteControllToolStripMenuItem.Name = "remoteControllToolStripMenuItem";
            this.remoteControllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.remoteControllToolStripMenuItem.Text = "Remote Controll";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.channelInfoToolStripMenuItem,
            this.shutDownServerToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(54, 17);
            this.controlToolStripMenuItem.Text = "Actions";
            this.controlToolStripMenuItem.Click += new System.EventHandler(this.controlToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fullScreenToolStripMenuItem.Text = "FullScreen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(479, 22);
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
            this.info_ChanName.Size = new System.Drawing.Size(327, 17);
            this.info_ChanName.Spring = true;
            this.info_ChanName.Text = "ProSieben";
            // 
            // info_signalStraingth
            // 
            this.info_signalStraingth.Name = "info_signalStraingth";
            this.info_signalStraingth.Size = new System.Drawing.Size(100, 16);
            this.info_signalStraingth.Value = 40;
            // 
            // osd_Info
            // 
            this.osd_Info.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.osd_Info.BackColor = System.Drawing.Color.Black;
            this.osd_Info.Controls.Add(this.osd_infoNext);
            this.osd_Info.Controls.Add(this.osd_InfoChan);
            this.osd_Info.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.osd_Info.Location = new System.Drawing.Point(12, 300);
            this.osd_Info.Name = "osd_Info";
            this.osd_Info.Size = new System.Drawing.Size(455, 80);
            this.osd_Info.TabIndex = 37;
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
            // ekran
            // 
            this.ekran.BackColor = System.Drawing.Color.White;
            this.ekran.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ekran.BackgroundImage")));
            this.ekran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ekran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ekran.Location = new System.Drawing.Point(0, 21);
            this.ekran.Name = "ekran";
            this.ekran.Size = new System.Drawing.Size(479, 387);
            this.ekran.TabIndex = 34;
            this.ekran.TabStop = false;
            // 
            // channelInfoToolStripMenuItem
            // 
            this.channelInfoToolStripMenuItem.Name = "channelInfoToolStripMenuItem";
            this.channelInfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.channelInfoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.channelInfoToolStripMenuItem.Text = "Channel Info";
            this.channelInfoToolStripMenuItem.Click += new System.EventHandler(this.channelInfoToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem1
            // 
            this.controlToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextChannelToolStripMenuItem,
            this.previuseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.rEcordToolStripMenuItem,
            this.muteToolStripMenuItem});
            this.controlToolStripMenuItem1.Name = "controlToolStripMenuItem1";
            this.controlToolStripMenuItem1.Size = new System.Drawing.Size(54, 17);
            this.controlToolStripMenuItem1.Text = "Control";
            // 
            // nextChannelToolStripMenuItem
            // 
            this.nextChannelToolStripMenuItem.Name = "nextChannelToolStripMenuItem";
            this.nextChannelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.nextChannelToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.nextChannelToolStripMenuItem.Text = "Next Channel";
            this.nextChannelToolStripMenuItem.Click += new System.EventHandler(this.nextChannelToolStripMenuItem_Click);
            // 
            // previuseToolStripMenuItem
            // 
            this.previuseToolStripMenuItem.Name = "previuseToolStripMenuItem";
            this.previuseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.previuseToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.previuseToolStripMenuItem.Text = "Previous Channel";
            this.previuseToolStripMenuItem.Click += new System.EventHandler(this.previuseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(214, 6);
            // 
            // rEcordToolStripMenuItem
            // 
            this.rEcordToolStripMenuItem.Name = "rEcordToolStripMenuItem";
            this.rEcordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rEcordToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.rEcordToolStripMenuItem.Text = "Record (start/stop)";
            this.rEcordToolStripMenuItem.Click += new System.EventHandler(this.rEcordToolStripMenuItem_Click);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.muteToolStripMenuItem.Text = "Mute";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.muteToolStripMenuItem_Click);
            // 
            // info_Recording
            // 
            this.info_Recording.BackColor = System.Drawing.SystemColors.Control;
            this.info_Recording.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_Recording.ForeColor = System.Drawing.Color.Red;
            this.info_Recording.Name = "info_Recording";
            this.info_Recording.Size = new System.Drawing.Size(0, 17);
            // 
            // shutDownServerToolStripMenuItem
            // 
            this.shutDownServerToolStripMenuItem.Name = "shutDownServerToolStripMenuItem";
            this.shutDownServerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.shutDownServerToolStripMenuItem.Text = "ShutDown Server";
            this.shutDownServerToolStripMenuItem.Click += new System.EventHandler(this.shutDownServerToolStripMenuItem_Click);
            // 
            // ViewVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 408);
            this.Controls.Add(this.osd_Info);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ekran);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DreamPlayer by Teo Eterovic";
            this.Load += new System.EventHandler(this.ViewVideo_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.VideoMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.osd_Info.ResumeLayout(false);
            this.osd_Info.PerformLayout();
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
        private System.Windows.Forms.PictureBox ekran;
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
    }
}