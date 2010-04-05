namespace VLCTestApp.Settings
{
    partial class WinLircSettingsDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLircSettingsDlg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wlPort = new System.Windows.Forms.TextBox();
            this.wlURI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wlCm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wlCi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wlFs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wlPc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wlNc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.epgURI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtmpURI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wlPort);
            this.groupBox1.Controls.Add(this.wlURI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WinLirc Server Settings:";
            // 
            // wlPort
            // 
            this.wlPort.Location = new System.Drawing.Point(259, 27);
            this.wlPort.Name = "wlPort";
            this.wlPort.Size = new System.Drawing.Size(49, 20);
            this.wlPort.TabIndex = 3;
            this.wlPort.Text = "8765";
            // 
            // wlURI
            // 
            this.wlURI.Location = new System.Drawing.Point(66, 27);
            this.wlURI.Name = "wlURI";
            this.wlURI.Size = new System.Drawing.Size(152, 20);
            this.wlURI.TabIndex = 2;
            this.wlURI.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(160, 355);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 22);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(253, 355);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 22);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wlCm);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.wlCi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.wlFs);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.wlPc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.wlNc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 188);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote mapping";
            // 
            // wlCm
            // 
            this.wlCm.Location = new System.Drawing.Point(145, 148);
            this.wlCm.Name = "wlCm";
            this.wlCm.Size = new System.Drawing.Size(151, 20);
            this.wlCm.TabIndex = 13;
            this.wlCm.Text = "chanMenu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Channel Menu:";
            // 
            // wlCi
            // 
            this.wlCi.Location = new System.Drawing.Point(145, 122);
            this.wlCi.Name = "wlCi";
            this.wlCi.Size = new System.Drawing.Size(151, 20);
            this.wlCi.TabIndex = 11;
            this.wlCi.Text = "chanInfo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Channel Info:";
            // 
            // wlFs
            // 
            this.wlFs.Location = new System.Drawing.Point(145, 96);
            this.wlFs.Name = "wlFs";
            this.wlFs.Size = new System.Drawing.Size(151, 20);
            this.wlFs.TabIndex = 9;
            this.wlFs.Text = "fullScreen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Full Screen:";
            // 
            // wlPc
            // 
            this.wlPc.Location = new System.Drawing.Point(145, 70);
            this.wlPc.Name = "wlPc";
            this.wlPc.Size = new System.Drawing.Size(151, 20);
            this.wlPc.TabIndex = 7;
            this.wlPc.Text = "prevChan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Previous Channel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "WinLirc Code";
            // 
            // wlNc
            // 
            this.wlNc.Location = new System.Drawing.Point(145, 44);
            this.wlNc.Name = "wlNc";
            this.wlNc.Size = new System.Drawing.Size(151, 20);
            this.wlNc.TabIndex = 4;
            this.wlNc.Text = "nextChan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Next Channel:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.epgURI);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.rtmpURI);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(6, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Streaming Server:";
            // 
            // epgURI
            // 
            this.epgURI.Location = new System.Drawing.Point(93, 50);
            this.epgURI.Name = "epgURI";
            this.epgURI.Size = new System.Drawing.Size(202, 20);
            this.epgURI.TabIndex = 3;
            this.epgURI.Text = "http://127.0.0.1/epg/epg.php";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "EPG List:";
            // 
            // rtmpURI
            // 
            this.rtmpURI.Location = new System.Drawing.Point(93, 21);
            this.rtmpURI.Name = "rtmpURI";
            this.rtmpURI.Size = new System.Drawing.Size(202, 20);
            this.rtmpURI.TabIndex = 1;
            this.rtmpURI.Text = "rtsp://127.0.0.1/lista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "RTSP stream:";
            // 
            // WinLircSettingsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinLircSettingsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox wlPort;
        private System.Windows.Forms.TextBox wlURI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox wlNc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wlCm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wlCi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wlFs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wlPc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox epgURI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rtmpURI;
        private System.Windows.Forms.Label label9;
    }
}