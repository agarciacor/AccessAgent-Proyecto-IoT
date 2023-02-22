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

namespace ControlAcceso
{
    public partial class FormHistorico : Form
    {
        public FormHistorico()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        private void ActualizarTabla(string query = "SELECT * FROM HISTORICO INNER JOIN EMPLEADO ON E_Id_empleado = Id_empleado")
        {
            tablaHistorico.Items.Clear();
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
                    item = tablaHistorico.Items.Add((string)sqlite_datareader["ID_empleado"]);
                    item.SubItems.Add((string)sqlite_datareader["nombre"]);
                    item.SubItems.Add((string)sqlite_datareader["apaterno"]);
                    item.SubItems.Add((string)sqlite_datareader["amaterno"]);
                    item.SubItems.Add(Convert.ToDateTime(sqlite_datareader["fecha"]).ToString("yyyy-MM-dd"));
                    item.SubItems.Add(Convert.ToDateTime(sqlite_datareader["hora"]).ToString("hh:mm:ss"));
                    item.SubItems.Add((string)sqlite_datareader["tipo"]);
                    //nombre.Add((string)sqlite_datareader["C_Id_cargo"]);
                }
            }
            connection.Close();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
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
                "FROM HISTORICO INNER JOIN EMPLEADO ON E_Id_empleado = Id_empleado WHERE " +
                "ID_Empleado LIKE '%" + busqueda + "%'" +
                "OR nombre LIKE '%" + busqueda + "%'" +
                "OR apaterno LIKE '%" + busqueda + "%'" +
                "OR hora LIKE '%" + busqueda + "%'" +
                "OR fecha LIKE '%" + busqueda + "%'" +
                "OR tipo LIKE '%" + busqueda + "%'" +
                "OR nombreCompleto LIKE '%" + busqueda + "%'";
            }
            else
            {
                query = "SELECT * FROM HISTORICO INNER JOIN EMPLEADO ON E_Id_empleado = Id_empleado";
            }

                ActualizarTabla(query);
        }
    }
}
