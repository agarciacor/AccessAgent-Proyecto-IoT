using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAcceso
{
    internal class SQLite
    {
        public SQLiteConnection CreateConnection()
        {
            string dataSource = @"Data Source=" + Properties.Settings.Default.RutaDB + "; Version=3;";

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection(dataSource);
         // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sqlite_conn;
        }

        public void InsertData(SQLiteConnection connection, string command)
        {
            try
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = command;
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void ReadData(SQLiteConnection connection, string command)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = command;

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (sqlite_datareader.HasRows)
            {
                while (sqlite_datareader.Read())
                {
                    string myreader = sqlite_datareader.GetString(0);
                    Console.WriteLine(myreader);
                }
            }
                
            connection.Close();
        }

        public List<string> SearchEmployee_GetNombre(SQLiteConnection connection, string rfid)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM EMPLEADO WHERE ID_Empleado = '" + rfid + "'";


            List<string> nombre = new List<string>();

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (sqlite_datareader.HasRows)
            {
                while (sqlite_datareader.Read())
                {
                    nombre.Add((string)sqlite_datareader["nombre"]);
                    nombre.Add((string)sqlite_datareader["apaterno"]);
                    nombre.Add((string)sqlite_datareader["amaterno"]);
                    nombre.Add((string)sqlite_datareader["sexo"]);
                    //nombre.Add((string)sqlite_datareader["C_Id_cargo"]);
                }
            }
            connection.Close();
            return nombre;
        }
    }
}
