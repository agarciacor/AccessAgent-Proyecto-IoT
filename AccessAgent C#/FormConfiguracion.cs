using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControlAcceso
{
    public partial class FormConfiguracion : Form
    {
        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            txtNombreEmpresa.Text = Properties.Settings.Default.NombreEmpresa;
            txtPuerto.Text = Properties.Settings.Default.Puerto;
            txtRutaDB.Text = Properties.Settings.Default.RutaDB;
            txtRutaCarpeta.Text = Properties.Settings.Default.RutaFotos;
            cmbTipoRegistro.Text = Properties.Settings.Default.TipoDeRegistro;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["NombreEmpresa"] = txtNombreEmpresa.Text;
            Properties.Settings.Default["Puerto"] = txtPuerto.Text;
            Properties.Settings.Default["RutaDB"] = txtRutaDB.Text;
            Properties.Settings.Default["RutaFotos"] = txtRutaCarpeta.Text;
            Properties.Settings.Default["TipoDeRegistro"] = cmbTipoRegistro.Text;

            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void btnExaminarCarpeta_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    txtRutaCarpeta.Text = fd.SelectedPath;
                }
            }
        }

        private void btnExaminarDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Examinar Base de Datos";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Data Base (*.db)|*.db";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtRutaDB.Text = fdlg.FileName;
            }

        }
    }
}
