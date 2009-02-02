namespace VLCTestApp
{
    partial class WoLDialog
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
            this.wake = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.MacAddress = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wake
            // 
            this.wake.Location = new System.Drawing.Point(184, 12);
            this.wake.Name = "wake";
            this.wake.Size = new System.Drawing.Size(75, 23);
            this.wake.TabIndex = 0;
            this.wake.Text = "WakeUp";
            this.wake.UseVisualStyleBackColor = true;
            this.wake.Click += new System.EventHandler(this.wake_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 40);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(269, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(99, 17);
            this.status.Text = "Enter MAC address";
            // 
            // MacAddress
            // 
            this.MacAddress.Location = new System.Drawing.Point(10, 13);
            this.MacAddress.Mask = "aa-aa-aa-aa-aa-aa";
            this.MacAddress.Name = "MacAddress";
            this.MacAddress.Size = new System.Drawing.Size(168, 20);
            this.MacAddress.TabIndex = 3;
            this.MacAddress.Text = "003018a6b1f0";
            this.MacAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WoLDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 62);
            this.Controls.Add(this.MacAddress);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.wake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WoLDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoLDialog";
            this.Load += new System.EventHandler(this.WoLDialog_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wake;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.MaskedTextBox MacAddress;
    }
}