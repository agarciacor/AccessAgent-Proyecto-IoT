namespace ControlAcceso
{
    partial class FormPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonal));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablaInventario = new System.Windows.Forms.ListView();
            this.colRFID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApaterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmaterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPuesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1090, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal";
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
            this.panel1.Size = new System.Drawing.Size(1255, 86);
            this.panel1.TabIndex = 3;
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
            // tablaInventario
            // 
            this.tablaInventario.AllowColumnReorder = true;
            this.tablaInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaInventario.BackColor = System.Drawing.Color.White;
            this.tablaInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablaInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRFID,
            this.colNombre,
            this.colApaterno,
            this.colAmaterno,
            this.colSexo,
            this.colPuesto,
            this.colDepartamento});
            this.tablaInventario.FullRowSelect = true;
            this.tablaInventario.GridLines = true;
            this.tablaInventario.HideSelection = false;
            this.tablaInventario.Location = new System.Drawing.Point(12, 136);
            this.tablaInventario.MultiSelect = false;
            this.tablaInventario.Name = "tablaInventario";
            this.tablaInventario.Size = new System.Drawing.Size(1216, 508);
            this.tablaInventario.TabIndex = 9;
            this.tablaInventario.UseCompatibleStateImageBehavior = false;
            this.tablaInventario.View = System.Windows.Forms.View.Details;
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
            // colSexo
            // 
            this.colSexo.Text = "Sexo";
            this.colSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colPuesto
            // 
            this.colPuesto.Text = "Puesto";
            this.colPuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPuesto.Width = 250;
            // 
            // colDepartamento
            // 
            this.colDepartamento.Text = "Departamento";
            this.colDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDepartamento.Width = 200;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(714, 94);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(514, 31);
            this.txtBusqueda.TabIndex = 10;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::ControlAcceso.Properties.Resources.btnBorrar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(606, 92);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(39, 36);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::ControlAcceso.Properties.Resources.btnEditar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(657, 92);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(39, 36);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnRecargar.TabIndex = 11;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 656);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.tablaInventario);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Agent - Personal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView tablaInventario;
        private System.Windows.Forms.ColumnHeader colRFID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApaterno;
        private System.Windows.Forms.ColumnHeader colAmaterno;
        private System.Windows.Forms.ColumnHeader colPuesto;
        private System.Windows.Forms.ColumnHeader colDepartamento;
        private System.Windows.Forms.ColumnHeader colSexo;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
    }
}