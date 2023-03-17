using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Collections;
namespace WFPrueba
{
    public partial class Form1 : Form
    {
        static ArrayList mailsRegistrados = new ArrayList();
        static Form2 segundaVentana = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private void botonEnviar_Click(object sender, EventArgs e)
        {
            mailsRegistrados.Add(textMail.Text);
            segundaVentana = new Form2();

            if (textMail.Text.Contains("@hotmail.com") != true || textPassword.Text.Length <= 0)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                segundaVentana.Show();
                segundaVentana.setCuenta(textMail.Text, textPassword.Text);
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        int x, y;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Left += e.X - x;
                Top += e.Y - y;
                
            }
        }
    }
}
