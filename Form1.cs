using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Golf_2D
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }
        private int contador = 0;

        public string[] imagenes = { "D:\\Escritorio\\UPC\\U2023-1\\IA ADITH\\TERCER CORTE\\PUNTO 2\\Golf 2D\\Imagenes y logos\\Play 1.png", "D:\\Escritorio\\UPC\\U2023-1\\IA ADITH\\TERCER CORTE\\PUNTO 2\\Golf 2D\\Imagenes y logos\\Play 2.png" };


        private void Timer_Tick(object sender, EventArgs e)
        {
            contador++;

            if (contador >= imagenes.Length)
            {
                contador = 0;
            }
            //BtnPlay.BackgroundImage.
            BtnPlay.Image = Image.FromFile(imagenes[contador]);
            
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Nivel_1 Primer_nivel = new Nivel_1();
            Primer_nivel.Show();
            Timer.Stop();
            this.Hide();



        }
    }
}
