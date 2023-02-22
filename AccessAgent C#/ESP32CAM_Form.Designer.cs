namespace ControlAcceso
{
    partial class ESP32CAM_Form
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
            this.pbxVideo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxVideo
            // 
            this.pbxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxVideo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxVideo.Location = new System.Drawing.Point(12, 12);
            this.pbxVideo.Name = "pbxVideo";
            this.pbxVideo.Size = new System.Drawing.Size(682, 606);
            this.pbxVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVideo.TabIndex = 15;
            this.pbxVideo.TabStop = false;
            // 
            // ESP32CAM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 636);
            this.Controls.Add(this.pbxVideo);
            this.Name = "ESP32CAM_Form";
            this.Text = "Stream Video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ESP32CAM_Form_FormClosing);
            this.Load += new System.EventHandler(this.ESP32CAM_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxVideo;
    }
}