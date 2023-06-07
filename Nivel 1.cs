using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf_2D
{
    public partial class Nivel_1 : Form
    {
        public Nivel_1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);         
        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Nivel_1_Load(object sender, EventArgs e)
        {
          
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            BarPotencia.Value = 15;
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            BarPotencia.Value = 30;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            BarPotencia.Value = 45;
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            BarPotencia.Value = 60;
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            BarPotencia.Value = 74;
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            BarPotencia.Value = 87;
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            BarPotencia.Value = 100;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            BarPotencia.Value = 0;
        }
    }
}
