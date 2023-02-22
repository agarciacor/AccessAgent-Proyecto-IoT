namespace ControlAcceso
{
    partial class FormRFID_VistaDatos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtTipoRegistro = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.pbxVideo = new System.Windows.Forms.PictureBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.txtHora);
            this.panel2.Controls.Add(this.txtTipoRegistro);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(658, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 267);
            this.panel2.TabIndex = 12;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(91, 209);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(413, 33);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.Text = "Today";
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.White;
            this.txtHora.Location = new System.Drawing.Point(91, 82);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(413, 113);
            this.txtHora.TabIndex = 2;
            this.txtHora.Text = "00:00";
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipoRegistro
            // 
            this.txtTipoRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.txtTipoRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoRegistro.ForeColor = System.Drawing.Color.White;
            this.txtTipoRegistro.Location = new System.Drawing.Point(15, 12);
            this.txtTipoRegistro.Name = "txtTipoRegistro";
            this.txtTipoRegistro.ReadOnly = true;
            this.txtTipoRegistro.Size = new System.Drawing.Size(561, 40);
            this.txtTipoRegistro.TabIndex = 1;
            this.txtTipoRegistro.Text = "Entrada / Salida registrada";
            this.txtTipoRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(15, 172);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(561, 31);
            this.txtCargo.TabIndex = 11;
            this.txtCargo.Text = "Puesto en la Empresa";
            this.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(10, 496);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(286, 19);
            this.txtID.TabIndex = 10;
            this.txtID.Text = "ID: 00000000";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(15, 101);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(561, 40);
            this.txtApellidos.TabIndex = 9;
            this.txtApellidos.Text = "Apaterno Amaterno";
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(15, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(561, 55);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Text = "NombreA NombreB";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtCargo);
            this.panel1.Location = new System.Drawing.Point(658, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 245);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txtDistancia);
            this.panel3.Controls.Add(this.pbxVideo);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.pbxImagen);
            this.panel3.Location = new System.Drawing.Point(44, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 518);
            this.panel3.TabIndex = 14;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDistancia.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDistancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDistancia.Location = new System.Drawing.Point(23, 416);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.ReadOnly = true;
            this.txtDistancia.Size = new System.Drawing.Size(561, 40);
            this.txtDistancia.TabIndex = 17;
            this.txtDistancia.Text = "Distancia";
            this.txtDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxVideo
            // 
            this.pbxVideo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxVideo.Location = new System.Drawing.Point(302, 11);
            this.pbxVideo.Name = "pbxVideo";
            this.pbxVideo.Size = new System.Drawing.Size(292, 389);
            this.pbxVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVideo.TabIndex = 16;
            this.pbxVideo.TabStop = false;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxImagen.Image = global::ControlAcceso.Properties.Resources.fotoNobinario;
            this.pbxImagen.Location = new System.Drawing.Point(10, 11);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(286, 389);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 7;
            this.pbxImagen.TabStop = false;
            // 
            // FormRFID_VistaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRFID_VistaDatos";
            this.Text = "VistaEntrada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRFID_VistaDatos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRFID_VistaDatos_FormClosed);
            this.Load += new System.EventHandler(this.FormRFID_VistaDatos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtFecha;
        public System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.TextBox txtTipoRegistro;
        public System.Windows.Forms.TextBox txtCargo;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox pbxVideo;
        public System.Windows.Forms.TextBox txtDistancia;
    }
}