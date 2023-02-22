namespace ControlAcceso
{
    partial class FormReloj
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
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hora
            // 
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempo.Font = new System.Drawing.Font("Open Sans", 180F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(112, 63);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(1051, 327);
            this.txtTiempo.TabIndex = 1;
            this.txtTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::ControlAcceso.Properties.Resources.rfidIcono;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1043, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 112);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeyenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeyenda.Font = new System.Drawing.Font("Open Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyenda.Location = new System.Drawing.Point(270, 433);
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.ReadOnly = true;
            this.txtLeyenda.Size = new System.Drawing.Size(767, 48);
            this.txtLeyenda.TabIndex = 3;
            this.txtLeyenda.Text = "Coloque su credencial sobre el lector";
            this.txtLeyenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormReloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 581);
            this.Controls.Add(this.txtLeyenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTiempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReloj";
            this.Text = "FormInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLeyenda;
    }
}