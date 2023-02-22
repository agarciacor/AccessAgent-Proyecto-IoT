namespace ControlAcceso
{
    partial class FormRegistrarEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarEmpleado));
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApaterno = new System.Windows.Forms.Label();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.lblAmaterno = new System.Windows.Forms.Label();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.rbtnNoBinario = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarDepartamento = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(605, 120);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(123, 19);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "00000000";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 86);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControlAcceso.Properties.Resources.AccessAgentLogo_FondoOscuro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
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
            this.label1.Location = new System.Drawing.Point(513, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Empleado";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(196, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(78, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 25);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre(s)";
            // 
            // lblApaterno
            // 
            this.lblApaterno.AutoSize = true;
            this.lblApaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApaterno.Location = new System.Drawing.Point(22, 59);
            this.lblApaterno.Name = "lblApaterno";
            this.lblApaterno.Size = new System.Drawing.Size(168, 25);
            this.lblApaterno.TabIndex = 5;
            this.lblApaterno.Text = "Apellido paterno";
            // 
            // txtApaterno
            // 
            this.txtApaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApaterno.Location = new System.Drawing.Point(196, 56);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(281, 31);
            this.txtApaterno.TabIndex = 4;
            // 
            // lblAmaterno
            // 
            this.lblAmaterno.AutoSize = true;
            this.lblAmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmaterno.Location = new System.Drawing.Point(22, 96);
            this.lblAmaterno.Name = "lblAmaterno";
            this.lblAmaterno.Size = new System.Drawing.Size(173, 25);
            this.lblAmaterno.TabIndex = 7;
            this.lblAmaterno.Text = "Apellido materno";
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmaterno.Location = new System.Drawing.Point(196, 93);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(281, 31);
            this.txtAmaterno.TabIndex = 6;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(120, 33);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(70, 25);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCargo.Location = new System.Drawing.Point(196, 30);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(250, 33);
            this.cmbCargo.TabIndex = 10;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbDepartamento.Location = new System.Drawing.Point(196, 79);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(250, 33);
            this.cmbDepartamento.TabIndex = 12;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(43, 82);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(147, 25);
            this.lblDepartamento.TabIndex = 11;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(129, 136);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(61, 25);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo";
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHombre.Location = new System.Drawing.Point(208, 138);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(84, 24);
            this.rbtnHombre.TabIndex = 14;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            this.rbtnHombre.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMujer.Location = new System.Drawing.Point(298, 138);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(66, 24);
            this.rbtnMujer.TabIndex = 15;
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnNoBinario
            // 
            this.rbtnNoBinario.AutoSize = true;
            this.rbtnNoBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNoBinario.Location = new System.Drawing.Point(370, 138);
            this.rbtnNoBinario.Name = "rbtnNoBinario";
            this.rbtnNoBinario.Size = new System.Drawing.Size(98, 24);
            this.rbtnNoBinario.TabIndex = 16;
            this.rbtnNoBinario.TabStop = true;
            this.rbtnNoBinario.Text = "No binario";
            this.rbtnNoBinario.UseVisualStyleBackColor = true;
            this.rbtnNoBinario.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(605, 490);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 48);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(560, 120);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 20);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtApaterno);
            this.groupBox1.Controls.Add(this.lblApaterno);
            this.groupBox1.Controls.Add(this.rbtnNoBinario);
            this.groupBox1.Controls.Add(this.txtAmaterno);
            this.groupBox1.Controls.Add(this.rbtnMujer);
            this.groupBox1.Controls.Add(this.lblAmaterno);
            this.groupBox1.Controls.Add(this.rbtnHombre);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Location = new System.Drawing.Point(246, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 189);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarDepartamento);
            this.groupBox2.Controls.Add(this.btnAgregarCargo);
            this.groupBox2.Controls.Add(this.cmbDepartamento);
            this.groupBox2.Controls.Add(this.lblCargo);
            this.groupBox2.Controls.Add(this.cmbCargo);
            this.groupBox2.Controls.Add(this.lblDepartamento);
            this.groupBox2.Location = new System.Drawing.Point(246, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 134);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empresa";
            // 
            // btnAgregarDepartamento
            // 
            this.btnAgregarDepartamento.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgAgregar;
            this.btnAgregarDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDepartamento.FlatAppearance.BorderSize = 0;
            this.btnAgregarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDepartamento.Location = new System.Drawing.Point(459, 79);
            this.btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            this.btnAgregarDepartamento.Size = new System.Drawing.Size(30, 33);
            this.btnAgregarDepartamento.TabIndex = 24;
            this.btnAgregarDepartamento.UseVisualStyleBackColor = true;
            this.btnAgregarDepartamento.Click += new System.EventHandler(this.btnAgregarDepartamento_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgAgregar;
            this.btnAgregarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarCargo.FlatAppearance.BorderSize = 0;
            this.btnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCargo.Location = new System.Drawing.Point(459, 30);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(30, 33);
            this.btnAgregarCargo.TabIndex = 23;
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbxFoto);
            this.groupBox3.Controls.Add(this.btnFoto);
            this.groupBox3.Location = new System.Drawing.Point(35, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 329);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // pbxFoto
            // 
            this.pbxFoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbxFoto.Image = global::ControlAcceso.Properties.Resources.fotoNobinario;
            this.pbxFoto.Location = new System.Drawing.Point(15, 22);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(169, 241);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 16;
            this.pbxFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.BackgroundImage = global::ControlAcceso.Properties.Resources.btnImgCamara;
            this.btnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Location = new System.Drawing.Point(15, 269);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(169, 48);
            this.btnFoto.TabIndex = 19;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(780, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Access Agent - Registrar Empleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApaterno;
        private System.Windows.Forms.Label lblAmaterno;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblSexo;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApaterno;
        public System.Windows.Forms.TextBox txtAmaterno;
        public System.Windows.Forms.ComboBox cmbCargo;
        public System.Windows.Forms.ComboBox cmbDepartamento;
        public System.Windows.Forms.RadioButton rbtnHombre;
        public System.Windows.Forms.RadioButton rbtnMujer;
        public System.Windows.Forms.RadioButton rbtnNoBinario;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Button btnAgregarDepartamento;
        private System.Windows.Forms.Timer timer1;
    }
}