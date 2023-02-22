using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAcceso
{
    public partial class FormReloj : Form
    {
        int contador = 0;
        public FormReloj()
        {
            InitializeComponent();
            hora.Start();
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            txtTiempo.Text = DateTime.Now.ToString("HH:mm:ss");

            contador++;
            if (contador == 31)
            {
                
                txtLeyenda.Text = "El sistema validará su identidad";
            }
            else if(contador == 61)
            {
                contador = 0;
            }
            else if (contador == 1)
            {
                txtLeyenda.Text = "Coloque su credencial sobre el lector";
            }
        }
    }
}
