namespace ControlAcceso
{
    partial class FormHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorico));
            this.btnRecargar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tablaHistorico = new System.Windows.Forms.ListView();
            this.colRFID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApaterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmaterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackgroundImage = global::ControlAcceso.Properties.Resources.btnActualizar;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargar.FlatAppearance.BorderSize = 0;
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargar.Location = new System.Drawing.Point(17, 95);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(39, 36);
            this.btnRecargar.TabIndex = 17;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(717, 95);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(376, 31);
            this.txtBusqueda.TabIndex = 16;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // tablaHistorico
            // 
            this.tablaHistorico.AllowColumnReorder = true;
            this.tablaHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaHistorico.BackColor = System.Drawing.Color.White;
            this.tablaHistorico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablaHistorico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRFID,
            this.colNombre,
            this.colApaterno,
            this.colAmaterno,
            this.colFecha,
            this.colHora,
            this.colTipo});
            this.tablaHistorico.FullRowSelect = true;
            this.tablaHistorico.GridLines = true;
            this.tablaHistorico.HideSelection = false;
            this.tablaHistorico.Location = new System.Drawing.Point(12, 136);
            this.tablaHistorico.MultiSelect = false;
            this.tablaHistorico.Name = "tablaHistorico";
            this.tablaHistorico.Size = new System.Drawing.Size(1081, 457);
            this.tablaHistorico.TabIndex = 15;
            this.tablaHistorico.UseCompatibleStateImageBehavior = false;
            this.tablaHistorico.View = System.Windows.Forms.View.Details;
            // 
            // colRFID
            // 
            this.colRFID.Text = "RFID";
            this.colRFID.Width = 95;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre (s)";
            this.colNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNombre.Width = 248;
            // 
            // colApaterno
            // 
            this.colApaterno.Text = "Apellido paterno";
            this.colApaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colApaterno.Width = 180;
            // 
            // colAmaterno
            // 
            this.colAmaterno.Text = "Apellido materno";
            this.colAmaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAmaterno.Width = 180;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFecha.Width = 138;
            // 
            // colHora
            // 
            this.colHora.Text = "Hora";
            this.colHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHora.Width = 80;
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            this.colTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTipo.Width = 157;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 86);
            this.panel1.TabIndex = 14;
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(934, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historico";
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 605);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.tablaHistorico);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Agent - Historico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecargar;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ListView tablaHistorico;
        private System.Windows.Forms.ColumnHeader colRFID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApaterno;
        private System.Windows.Forms.ColumnHeader colAmaterno;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colTipo;
    }
}