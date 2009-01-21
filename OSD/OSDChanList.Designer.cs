namespace VLCTestApp.OSD
{
    partial class OSDChanList
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
            this.chanList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chanList
            // 
            this.chanList.BackColor = System.Drawing.Color.DimGray;
            this.chanList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chanList.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chanList.ForeColor = System.Drawing.Color.White;
            this.chanList.FormattingEnabled = true;
            this.chanList.ItemHeight = 18;
            this.chanList.Items.AddRange(new object[] {
            "PRemiere",
            "BHTV 1",
            "PRemiere World",
            "KAbel 1",
            "PRemiere",
            "BHTV 1",
            "PRemiere World",
            "KAbel 1",
            "PRemiere",
            "BHTV 1",
            "PRemiere World",
            "KAbel 1",
            "PRemiere",
            "BHTV 1",
            "PRemiere",
            "BHTV 1"});
            this.chanList.Location = new System.Drawing.Point(9, 14);
            this.chanList.Name = "chanList";
            this.chanList.Size = new System.Drawing.Size(377, 342);
            this.chanList.TabIndex = 0;
            // 
            // OSDChanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(400, 371);
            this.Controls.Add(this.chanList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OSDChanList";
            this.Opacity = 0.7;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSDChanList";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox chanList;
    }
}