using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCapture
{
    public partial class Application : Form
    {
        MemoryStream ms;
        NetworkStream stream;

        Bitmap memoryImage;

        public Application()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonStream_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Capture);
            t.Start();
        }
        private void ButtonScreen_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            imageCapture.Image = bitmap;
        }

        void Capture()
        {
            while (true)
            {
                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphic = Graphics.FromImage(bitmap);
                graphic.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                imageCapture.Image = bitmap;
                Thread.Sleep(100);
            }
        }
    }
}
