using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControlAcceso
{
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        private void ActualizarTabla(string query = "SELECT * FROM EMPLEADO")
        {
            tablaInventario.Items.Clear();
            SQLiteConnection connection = new SQLite().CreateConnection();

            string busqueda = txtBusqueda.Text.Trim();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = query;

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (sqlite_datareader.HasRows)
            {
                while (sqlite_datareader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item = tablaInventario.Items.Add((string)sqlite_datareader["ID_empleado"]);
                    item.SubItems.Add((string)sqlite_datareader["nombre"]);
                    item.SubItems.Add((string)sqlite_datareader["apaterno"]);
                    item.SubItems.Add((string)sqlite_datareader["amaterno"]);
                    item.SubItems.Add((string)sqlite_datareader["sexo"]);
                    //nombre.Add((string)sqlite_datareader["C_Id_cargo"]);
                }
            }
            connection.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
            txtBusqueda.Text = "";
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBusqueda.Text.Trim();
            string query;
            if (busqueda != "")
            {
                query = "SELECT *, nombre || ' ' || apaterno || ' ' || amaterno AS nombreCompleto " +
                "FROM EMPLEADO WHERE " +
                "ID_Empleado LIKE '%" + busqueda + "%'" +
                "OR nombre LIKE '%" + busqueda + "%'" +
                "OR apaterno LIKE '%" + busqueda + "%'" +
                "OR sexo LIKE '%" + busqueda + "%'" +
                "OR nombreCompleto LIKE '%" + busqueda + "%'";// +
                                                    //"OR nombre LIKE '%" + busqueda + "%'" +
            }
            else
            {
                query = "SELECT * FROM EMPLEADO";
            }


            ActualizarTabla(query);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaInventario.SelectedItems.Count > 0)
            {
                string rfid = tablaInventario.SelectedItems[0].SubItems[0].Text;
                FormRegistrarEmpleado registrarEmpleado = new FormRegistrarEmpleado(rfid);
                registrarEmpleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tablaInventario.SelectedItems.Count > 0)
            {
                string rfid = tablaInventario.SelectedItems[0].SubItems[0].Text;

                DialogResult result = MessageBox.Show("Estas seguro de borrar el registro " + rfid + "?", "CONFIRMAR", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SQLite sQLite = new SQLite();
                    sQLite.InsertData(new SQLite().CreateConnection(), "DELETE FROM EMPLEADO where ID_Empleado = '" + rfid + "';");
                }

                ActualizarTabla();

                
            }
            else
            {
                MessageBox.Show("Seleccione un registro para borrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
