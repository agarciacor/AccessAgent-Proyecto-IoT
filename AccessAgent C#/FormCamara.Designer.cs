namespace ControlAcceso
{
    partial class FormCamara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCamara));
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCapturarFoto = new System.Windows.Forms.Button();
            this.pbxFotoFinal = new System.Windows.Forms.PictureBox();
            this.pbxVideo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCamara
            // 
            this.cmbCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(816, 26);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(264, 28);
            this.cmbCamara.TabIndex = 13;
            this.cmbCamara.SelectedIndexChanged += new System.EventHandler(this.cmbCamara_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(646, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(161, 20);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "Camaras detectadas:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "La imagen se guardará en:";
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.SystemColors.Control;
            this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(15, 28);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(583, 19);
            this.txtRuta.TabIndex = 23;
            this.txtRuta.Text = "PATH";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgGuardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(958, 433);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 48);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCapturarFoto
            // 
            this.btnCapturarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapturarFoto.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgCamara;
            this.btnCapturarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapturarFoto.FlatAppearance.BorderSize = 0;
            this.btnCapturarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturarFoto.Location = new System.Drawing.Point(816, 433);
            this.btnCapturarFoto.Name = "btnCapturarFoto";
            this.btnCapturarFoto.Size = new System.Drawing.Size(122, 48);
            this.btnCapturarFoto.TabIndex = 20;
            this.btnCapturarFoto.UseVisualStyleBackColor = true;
            this.btnCapturarFoto.Click += new System.EventHandler(this.btnCapturarFoto_Click);
            // 
            // pbxFotoFinal
            // 
            this.pbxFotoFinal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbxFotoFinal.Image = global::ControlAcceso.Properties.Resources.fotoNobinario;
            this.pbxFotoFinal.Location = new System.Drawing.Point(816, 68);
            this.pbxFotoFinal.Name = "pbxFotoFinal";
            this.pbxFotoFinal.Size = new System.Drawing.Size(264, 359);
            this.pbxFotoFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFotoFinal.TabIndex = 15;
            this.pbxFotoFinal.TabStop = false;
            // 
            // pbxVideo
            // 
            this.pbxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxVideo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxVideo.Location = new System.Drawing.Point(12, 68);
            this.pbxVideo.Name = "pbxVideo";
            this.pbxVideo.Size = new System.Drawing.Size(795, 413);
            this.pbxVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVideo.TabIndex = 14;
            this.pbxVideo.TabStop = false;
            // 
            // FormCamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1092, 493);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCapturarFoto);
            this.Controls.Add(this.pbxFotoFinal);
            this.Controls.Add(this.pbxVideo);
            this.Controls.Add(this.cmbCamara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCamara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Agent - Camara";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCamara_FormClosed);
            this.Load += new System.EventHandler(this.FormCamara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.PictureBox pbxVideo;
        private System.Windows.Forms.PictureBox pbxFotoFinal;
        public System.Windows.Forms.Button btnCapturarFoto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtRuta;
        public System.Windows.Forms.Button btnGuardar;
    }
}