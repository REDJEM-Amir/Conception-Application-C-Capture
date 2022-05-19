using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCapture
{
    public partial class Application : Form
    {
        MemoryStream ms;
        NetworkStream stream;
        public Application()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[277557];


            ms = new MemoryStream(bytes);
            imageCapture.Image = Image.FromStream(ms);

            ms.Dispose();
            stream.Dispose();
        }

        private void buttonStream_Click(object sender, EventArgs e)
        {

        }

        private void ButtonScreen_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            imageCapture.Image = bitmap;
        }
    }
}
