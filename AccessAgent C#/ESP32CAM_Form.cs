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
    public partial class ESP32CAM_Form : Form
    {
        MJPEGStream streamVideo;
        public ESP32CAM_Form()
        {
            InitializeComponent();
            
        }

        private void ESP32CAM_Form_Load(object sender, EventArgs e)
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

        private void ESP32CAM_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            streamVideo.Stop();
        }
    }
}
