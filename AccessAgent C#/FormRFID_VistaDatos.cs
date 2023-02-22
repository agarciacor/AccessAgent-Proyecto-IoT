using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;

namespace ControlAcceso
{
    public partial class FormRFID_VistaDatos : Form
    {
        public MJPEGStream streamVideo;
        public FormRFID_VistaDatos()
        {
            InitializeComponent();
        }

        private void FormRFID_VistaDatos_Load(object sender, EventArgs e)
        {
            streamVideo = new MJPEGStream("http://192.168.0.22:81/stream");
            streamVideo.NewFrame += GetNewFrame;
            streamVideo.Start();
        }

        public void GetNewFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap bmp = (Bitmap)e.Frame.Clone();
            pbxVideo.Image = bmp;
        }

        private void FormRFID_VistaDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            streamVideo.Stop();
        }

        private void FormRFID_VistaDatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //streamVideo.Stop();
        }
    }
}
