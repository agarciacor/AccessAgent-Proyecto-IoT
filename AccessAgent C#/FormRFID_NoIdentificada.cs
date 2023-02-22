using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAcceso
{
    public partial class FormRFID_NoIdentificada : Form
    {
        public FormRFID_NoIdentificada(string RFID)
        {
            InitializeComponent();
            txtID.Text = RFID;

            //Port.Write("r");
        }
    }
}
