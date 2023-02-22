using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Newtonsoft.Json;
using AForge.Video;

namespace ControlAcceso
{
    public partial class FormMaster : Form
    {
        MqttClient mqttClient;


        bool isClosed = false;
        bool isNewUserEnabled = false;
        string lastRead;

        int contSegundos = 0;

        Thread thread;

        SQLite sQLite = new SQLite();
        FormRFID_VistaDatos vEntrada = new FormRFID_VistaDatos();

        public FormMaster()
        {
            InitializeComponent();

            AbrirFormularioHijo(vEntrada, panelContenedor);
            AbrirFormularioHijo(new FormReloj(), panelContenedor);
            txtNombreEmpresa.Text = Properties.Settings.Default.NombreEmpresa;
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            //thread = new Thread(SerialListen);
            //thread.Start();
            Task.Run(() =>
            {
                mqttClient = new MqttClient("test.mosquitto.org");
                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishRecibed;
                mqttClient.Subscribe(new String[] { "accessAgent/Lecturas/RFID" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                mqttClient.Connect("Control Acceso");
            });

        }

        public void MqttClient_MqttMsgPublishRecibed(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var mensaje = Encoding.UTF8.GetString(e.Message);
            //txtNombreEmpresa.Text = mensaje;

            dynamic jsonObj = JsonConvert.DeserializeObject(mensaje);
            //Console.WriteLine(jsonObj);
            var RFID = jsonObj["LecturaRFID"].ToString();
            var Distancia = jsonObj["DistanciaCM"];
            //txtNombreEmpresa.Text = RFID + " .|. "+ Distancia;

            if (isNewUserEnabled)
            {

                isNewUserEnabled = false;
                btnRegistrarUsuarios.BackgroundImage = Properties.Resources.btnImgGuardarOFF;
                FormRegistrarEmpleado registrarEmpleado = new FormRegistrarEmpleado(RFID);
                registrarEmpleado.ShowDialog();

            }
            else
            {
                AbrirFormularioHijo(vEntrada, panelContenedor);

                vEntrada.txtID.Invoke(new MethodInvoker
                (
                delegate
                {
                    //vEntrada.txtID.Text = "ID: " + lastRead;

                    List<string> data = sQLite.SearchEmployee_GetNombre(sQLite.CreateConnection(), RFID);

                    if (data.Count > 0 && data != null)
                    {
                        if (Distancia < 30 || Distancia > 100) {
                            vEntrada.txtDistancia.Text = "Fuera de Rango (" + Distancia + ")";
                        }
                        else
                        {
                            vEntrada.txtDistancia.Text = "Correcta (" + Distancia + ")";
                        }
                        EnviarComando("$OTORGAR_ACCESO");

                        vEntrada.txtID.Text = "ID: " + RFID;

                        string nombre = data[0];
                        string apaterno = data[1];
                        string amaterno = data[2];
                        string sexo = data[3];
                        //string id_cargo = data[4];

                        vEntrada.txtNombre.Text = nombre;
                        vEntrada.txtApellidos.Text = apaterno + " " + amaterno;
                        vEntrada.txtTipoRegistro.Text = Properties.Settings.Default.TipoDeRegistro;
                        //txtCargo.Text = id_cargo;

                        vEntrada.txtHora.Text = DateTime.Now.ToString("hh:mm:ss");
                        vEntrada.txtFecha.Text = DateTime.Now.ToLongDateString();

                        string actualizacion = "INSERT INTO HISTORICO(E_Id_empleado, hora, fecha, tipo) VALUES(" +
                            " '"
                            + RFID +
                            "', '"
                            + DateTime.Now.ToString("hh:mm:ss") +
                            "', '"
                            + DateTime.Now.ToString("yyyy-MM-dd") +
                            "', '"
                            + Properties.Settings.Default.TipoDeRegistro +
                            "');";
                        sQLite.InsertData(sQLite.CreateConnection(), actualizacion);

                        string fotoPath = Properties.Settings.Default.RutaFotos + "\\" + RFID + ".jpg";

                        if (File.Exists(fotoPath))
                        {
                            vEntrada.pbxImagen.Image = Image.FromFile(fotoPath);
                        }
                        else
                        {
                            if (sexo == "H")
                            {
                                vEntrada.pbxImagen.Image = Properties.Resources.FotoHombre;
                            }
                            else if (sexo == "M")
                            {
                                vEntrada.pbxImagen.Image = Properties.Resources.fotoMujer;
                            }

                        }

                    }
                    else
                    {
                        AbrirFormularioHijo(new FormRFID_NoIdentificada(RFID), panelContenedor);
                        EnviarComando("$ACTIVAR_LED_R");
                    }

                    this.timer1.Stop();
                    contSegundos = 0;
                    this.timer1.Start();

                }
                ));

            }

        }

        public void GetNewFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap bmp = (Bitmap)e.Frame.Clone();
            //pbxVideo.Image = bmp;
        }



        private void FormMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void btnRegistrarUsuarios_Click(object sender, EventArgs e)
        {
            if (!isNewUserEnabled)
            {
                isNewUserEnabled = true;
                btnRegistrarUsuarios.BackgroundImage = Properties.Resources.btnImgGuardarON;
            } else if (isNewUserEnabled)
            {
                isNewUserEnabled = false;
                btnRegistrarUsuarios.BackgroundImage = Properties.Resources.btnImgGuardarOFF;
            }
            
        }

        private void FormMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            thread.Abort();
            Application.Exit();
        }

        public void AbrirFormularioHijo(Form formHijo, Panel panelContenedor)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        public void EnviarComando(String comando)
        {
            Task.Run(() =>
            {
                if (mqttClient.IsConnected)
                {
                    mqttClient.Publish("accessAgent/Lecturas/RFID_INPUT", Encoding.UTF8.GetBytes(comando));
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            contSegundos += 1;

            if(contSegundos == 5)
            {
                AbrirFormularioHijo(new FormReloj(), panelContenedor);
                contSegundos = 0;
                timer1.Stop();
            }
            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FormConfiguracion config = new FormConfiguracion();
            config.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FormPersonal personal = new FormPersonal();
            personal.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FormHistorico formHistorico = new FormHistorico();
            formHistorico.Show();
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            ESP32CAM_Form cam = new ESP32CAM_Form();
            cam.Show();
        }
    }
}
