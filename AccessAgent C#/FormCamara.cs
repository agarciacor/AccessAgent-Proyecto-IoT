using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ControlAcceso
{
    public partial class FormCamara : Form
    {
        private bool hayDispositivos;
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice webcam;
        private string ruta = Properties.Settings.Default.RutaFotos;
        private string newID;
        private Graphics g;
        private Pen crayon = new Pen(Color.Black, 3);
        Bitmap imagen;

        int rectanguloCordX;
        int rectanguloCordY;

        public FormCamara(string rfid)
        {
            InitializeComponent();
            newID = rfid;
        }

        private void FormCamara_Load(object sender, EventArgs e)
        {
            CargarDispositivo();
            txtRuta.Text = Properties.Settings.Default.RutaFotos;
        }

        public void CargarDispositivo()
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if(dispositivos.Count > 0)
            {
                hayDispositivos = true;
                for(int i = 0; i < dispositivos.Count; i++)
                {
                    cmbCamara.Items.Add(dispositivos[i].Name.ToString());
                }
                cmbCamara.Text = dispositivos[0].Name.ToString();
            }
            else
            {
                hayDispositivos = false;
            }
        }

        public void CerrarWebcam()
        {
            if(webcam!= null && webcam.IsRunning)
            {
                webcam.SignalToStop();
                //webcam.Stop();
                webcam = null;
            }
        }

        private void cmbCamara_SelectedIndexChanged(object sender, EventArgs e)
        {
            CerrarWebcam();
            string nombre = dispositivos[cmbCamara.SelectedIndex].MonikerString;

            webcam = new VideoCaptureDevice(nombre);
            webcam.NewFrame += new NewFrameEventHandler(Capturando);
            webcam.Start();
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            imagen = (Bitmap)eventArgs.Frame.Clone();
            pbxVideo.Image = imagen;
            g = pbxVideo.CreateGraphics();
            rectanguloCordX = (pbxVideo.Width / 2) - (260 / 2);
            rectanguloCordY = (pbxVideo.Height / 2) - (360 / 2);

            g.DrawRectangle(crayon, rectanguloCordX, rectanguloCordY, 260, 360);
        }

        private void FormCamara_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebcam();
        }

        private void btnCapturarFoto_Click(object sender, EventArgs e)
        {
            if(webcam != null && webcam.IsRunning)
            {
                
                Rectangle rect = new Rectangle(rectanguloCordX, rectanguloCordY, 260, 360);
                //pbxFotoFinal.Image = pbxVideo.Image;
                Bitmap bitImage = new Bitmap(pbxVideo.Image, pbxVideo.Width, pbxVideo.Height);
                pbxFotoFinal.Image = bitImage.Clone(rect,imagen.PixelFormat);
                //pbxFotoFinal.Image.Save(ruta + "\\" + newID + ".jpg", ImageFormat.Jpeg);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(pbxFotoFinal.Image != Properties.Resources.fotoNobinario)
            {
                pbxFotoFinal.Image.Save(ruta + "\\" + newID + ".jpg", ImageFormat.Jpeg);
            }
            
            CerrarWebcam();
            Close();
            
        }

    }
}
