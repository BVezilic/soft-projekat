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
using AForge.Video.DirectShow;

namespace PokerBot
{
    public partial class MainForm : Form
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                cbCameras.Items.Add(VideoCaptureDevice.Name);
            }

            cbCameras.SelectedIndex = 0;
            FinalVideo = new VideoCaptureDevice();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[cbCameras.SelectedIndex].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();             
        }

        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            pbCamera.Image = video;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalVideo.SignalToStop();
            FinalVideo.WaitForStop();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            FinalVideo.SignalToStop();
        }
    }
}
