using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ControlAcceso
{
    public partial class FormRegistrarEmpleado : Form
    {
        string fotoPath;
        string newID;
        SQLite sQLite = new SQLite();
        public FormRegistrarEmpleado(string id = "00000000")
        {
            InitializeComponent();

            timer1.Start();

            txtID.Text = id;
            newID = id.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");

            List<string> data = sQLite.SearchEmployee_GetNombre(sQLite.CreateConnection(), newID);

            fotoPath = Properties.Settings.Default.RutaFotos + "\\" + newID + ".jpg";

            if (File.Exists(fotoPath))
            {
                pbxFoto.Image = Image.FromFile(fotoPath);
            }

            if (data.Count > 0 && data != null)
            {
                this.txtID.Text = newID;

                string nombre = data[0];
                string apaterno = data[1];
                string amaterno = data[2];
                string sexo = data[3];
                //string id_cargo = data[4];

                this.txtNombre.Text = nombre;
                this.txtApaterno.Text = apaterno;
                this.txtAmaterno.Text = amaterno;
                //txtCargo.Text = id_cargo;

                if (sexo == "H")
                {
                    this.rbtnHombre.Checked = true;
                }
                else
                if (sexo == "M")
                {
                    this.rbtnMujer.Checked = true;
                }
                else
                if (sexo == "B")
                {
                    this.rbtnNoBinario.Checked = true;
                }

                if (File.Exists(fotoPath))
                {
                    pbxFoto.Image = Image.FromFile(fotoPath);
                }
                else
                if (sexo == "H" && !File.Exists(fotoPath))
                {
                    pbxFoto.Image = Properties.Resources.FotoHombre;
                }
                else if (sexo == "M" && !File.Exists(fotoPath))
                {
                    pbxFoto.Image = Properties.Resources.fotoMujer;
                }

                this.btnAgregar.Text = "Actualizar";



            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string error = "";

            string nombre = txtNombre.Text.Trim();
            string aPaterno = txtApaterno.Text.Trim();
            string aMaterno = txtAmaterno.Text.Trim();
            string cargo = "";// cmbCargo.SelectedItem.ToString();
            string departamento = ""; //cmbDepartamento.SelectedItem.ToString();

            string sexo;
            if (rbtnHombre.Checked) { sexo = "H"; } else
            if (rbtnMujer.Checked) { sexo = "M"; } else
            if (rbtnNoBinario.Checked) { sexo = "B"; }
            else { sexo = "?"; }

            Console.WriteLine(sexo);


            if (!(nombre.Length > 3))
            {
                error += "- El nombre debe tener al menos 3 caracteres.\n";
            }
            if (!(aPaterno.Length > 3))
            {
                error += "- El apellido paterno debe tener al menos 3 caracteres.\n";
            }
            if (cmbCargo.SelectedIndex == -1)
            {
                error += "- Debe selecciónar un cargo.\n";
            }
            else
            {
                cargo = cmbCargo.SelectedItem.ToString();
            }
            if (cmbDepartamento.SelectedIndex == -1)
            {
                error += "- Debe selecciónar un departamento.\n";
            }
            else
            {
                departamento = cmbDepartamento.SelectedItem.ToString();
            }

            if (error != "")
            {
                MessageBox.Show("Complete los campos correctamente:\n" + error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnAgregar.Text == "Actualizar")
                {
                    string actualizacion = "UPDATE EMPLEADO SET" +
                        " nombre = '"
                        + nombre +
                        "', apaterno = '"
                        + aPaterno +
                        "', amaterno = '"
                        + aMaterno +
                        "', sexo = '"
                        + sexo +
                        "', C_Id_cargo = null WHERE Id_empleado = '" + newID + "';";
                    sQLite.InsertData(sQLite.CreateConnection(), actualizacion);

                    System.Diagnostics.Debug.WriteLine(actualizacion);

                    this.Close();
                }
                else
                {
                    sQLite.InsertData(sQLite.CreateConnection(), "INSERT INTO EMPLEADO(Id_empleado, nombre, apaterno, amaterno, sexo, C_Id_cargo)" +
                        "VALUES ('"
                        + newID +
                        "', '"
                        + nombre +
                        "','"
                        + aPaterno +
                        "','"
                        + aMaterno +
                        "','"
                        + sexo +
                        "', null);");

                    this.Close();
                }
                
            }
            
            

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            pbxFoto.Image.Dispose();
            FormCamara camara = new FormCamara(newID);
            camara.ShowDialog();

            if (File.Exists(fotoPath))
            {
                pbxFoto.Image = Image.FromFile(fotoPath);
            }

        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHombre.Checked && !File.Exists(fotoPath))
            {
                pbxFoto.Image = Properties.Resources.FotoHombre;
            }
            else if (rbtnMujer.Checked && !File.Exists(fotoPath))
            {
                pbxFoto.Image = Properties.Resources.fotoMujer;
            }
            else if (rbtnNoBinario.Checked && !File.Exists(fotoPath))
            {
                pbxFoto.Image = Properties.Resources.fotoNobinario;
            }
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            if (cmbCargo.DropDownStyle == ComboBoxStyle.Simple)
            {
                cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
                btnAgregarCargo.BackgroundImage = Properties.Resources.btnImgAgregar;
            }
            else
            {
                cmbCargo.DropDownStyle = ComboBoxStyle.Simple;
                btnAgregarCargo.BackgroundImage = Properties.Resources.btnImgCombo;
            }
        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            if (cmbDepartamento.DropDownStyle == ComboBoxStyle.Simple)
            {
                cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
                btnAgregarDepartamento.BackgroundImage = Properties.Resources.btnImgAgregar;
            }
            else
            {
                cmbDepartamento.DropDownStyle = ComboBoxStyle.Simple;
                btnAgregarDepartamento.BackgroundImage = Properties.Resources.btnImgCombo;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
