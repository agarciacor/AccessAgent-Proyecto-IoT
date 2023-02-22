namespace ControlAcceso
{
    partial class FormConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutaDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnExaminarDB = new System.Windows.Forms.Button();
            this.btnExaminarCarpeta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRutaCarpeta = new System.Windows.Forms.TextBox();
            this.cmbTipoRegistro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControlAcceso.Properties.Resources.AccessAgentLogo_FondoOscuro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(566, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 86);
            this.panel1.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(32, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(235, 25);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre de la empresa:";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(37, 148);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(715, 31);
            this.txtNombreEmpresa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ruta de base de datos (*.db):";
            // 
            // txtRutaDB
            // 
            this.txtRutaDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaDB.Location = new System.Drawing.Point(37, 279);
            this.txtRutaDB.Name = "txtRutaDB";
            this.txtRutaDB.ReadOnly = true;
            this.txtRutaDB.Size = new System.Drawing.Size(609, 26);
            this.txtRutaDB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puerto de RFID:";
            this.label3.Visible = false;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.Location = new System.Drawing.Point(37, 437);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(169, 31);
            this.txtPuerto.TabIndex = 8;
            this.txtPuerto.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(652, 437);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 48);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnExaminarDB
            // 
            this.btnExaminarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminarDB.Location = new System.Drawing.Point(652, 276);
            this.btnExaminarDB.Name = "btnExaminarDB";
            this.btnExaminarDB.Size = new System.Drawing.Size(100, 31);
            this.btnExaminarDB.TabIndex = 19;
            this.btnExaminarDB.Text = "Examinar";
            this.btnExaminarDB.UseVisualStyleBackColor = true;
            this.btnExaminarDB.Click += new System.EventHandler(this.btnExaminarDB_Click);
            // 
            // btnExaminarCarpeta
            // 
            this.btnExaminarCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminarCarpeta.Location = new System.Drawing.Point(652, 351);
            this.btnExaminarCarpeta.Name = "btnExaminarCarpeta";
            this.btnExaminarCarpeta.Size = new System.Drawing.Size(100, 31);
            this.btnExaminarCarpeta.TabIndex = 22;
            this.btnExaminarCarpeta.Text = "Examinar";
            this.btnExaminarCarpeta.UseVisualStyleBackColor = true;
            this.btnExaminarCarpeta.Click += new System.EventHandler(this.btnExaminarCarpeta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ruta de Carpeta para Imagenes:";
            // 
            // txtRutaCarpeta
            // 
            this.txtRutaCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaCarpeta.Location = new System.Drawing.Point(37, 353);
            this.txtRutaCarpeta.Name = "txtRutaCarpeta";
            this.txtRutaCarpeta.ReadOnly = true;
            this.txtRutaCarpeta.Size = new System.Drawing.Size(609, 26);
            this.txtRutaCarpeta.TabIndex = 20;
            // 
            // cmbTipoRegistro
            // 
            this.cmbTipoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmbTipoRegistro.FormattingEnabled = true;
            this.cmbTipoRegistro.Items.AddRange(new object[] {
            "Entrada / Salida",
            "Entrada",
            "Salida"});
            this.cmbTipoRegistro.Location = new System.Drawing.Point(348, 435);
            this.cmbTipoRegistro.Name = "cmbTipoRegistro";
            this.cmbTipoRegistro.Size = new System.Drawing.Size(250, 33);
            this.cmbTipoRegistro.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo de registro:";
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoRegistro);
            this.Controls.Add(this.btnExaminarCarpeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRutaCarpeta);
            this.Controls.Add(this.btnExaminarDB);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRutaDB);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Agent - Configuracion";
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRutaDB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPuerto;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnExaminarDB;
        public System.Windows.Forms.Button btnExaminarCarpeta;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtRutaCarpeta;
        public System.Windows.Forms.ComboBox cmbTipoRegistro;
        private System.Windows.Forms.Label label5;
    }
}