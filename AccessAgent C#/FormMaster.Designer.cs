namespace ControlAcceso
{
    partial class FormMaster
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnRegistrarUsuarios = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStream = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnStream);
            this.panel1.Controls.Add(this.txtNombreEmpresa);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnRegistrarUsuarios);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1544, 86);
            this.panel1.TabIndex = 0;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.txtNombreEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(219, 25);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.ReadOnly = true;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(601, 31);
            this.txtNombreEmpresa.TabIndex = 6;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgConfiguracion;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(978, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(73, 62);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControlAcceso.Properties.Resources.AccessAgentLogo_FondoOscuro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnPersonal
            // 
            this.btnPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonal.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgPersonal;
            this.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Location = new System.Drawing.Point(1160, 12);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(73, 62);
            this.btnPersonal.TabIndex = 3;
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorico.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgHistorico;
            this.btnHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Location = new System.Drawing.Point(1069, 12);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(73, 62);
            this.btnHistorico.TabIndex = 2;
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnRegistrarUsuarios
            // 
            this.btnRegistrarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnRegistrarUsuarios.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgGuardarOFF;
            this.btnRegistrarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrarUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnRegistrarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnRegistrarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.btnRegistrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuarios.Location = new System.Drawing.Point(1252, 12);
            this.btnRegistrarUsuarios.Name = "btnRegistrarUsuarios";
            this.btnRegistrarUsuarios.Size = new System.Drawing.Size(62, 62);
            this.btnRegistrarUsuarios.TabIndex = 1;
            this.btnRegistrarUsuarios.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuarios.Click += new System.EventHandler(this.btnRegistrarUsuarios_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Location = new System.Drawing.Point(12, 92);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1300, 620);
            this.panelContenedor.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStream
            // 
            this.btnStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStream.BackgroundImage = global::ControlAcceso.Properties.Resources.btnLive;
            this.btnStream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStream.FlatAppearance.BorderSize = 0;
            this.btnStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStream.Location = new System.Drawing.Point(887, 12);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(73, 62);
            this.btnStream.TabIndex = 7;
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 717);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Agent V1.0.0 - Windows 64-bit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMaster_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMaster_FormClosed);
            this.Load += new System.EventHandler(this.FormMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarUsuarios;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnConfig;
        public System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Button btnStream;
    }
}

