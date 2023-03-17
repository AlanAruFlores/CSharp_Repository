using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonContricante
{
    public partial class Form1 : Form
    {

        static Server server;
        public static bool boolAttack;
        public static bool boolReceive;
        public static bool comienzo;
        public static string sprite;
        public Form1()
        {
            InitializeComponent();
            server = new Server();
            boolAttack = true;
            boolReceive = false;
            comienzo = true;
            this.labelAnuncio.Text = "Tu turno";
            pictureBox2.Image = Image.FromFile(sprite);
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (boolAttack == true)
            {
                server.attackEnemy();
                boolAttack = false;
                boolReceive = true;
                this.labelAnuncio.Text = "Espere el turno del Usuario";
            }
            else
            {
                MessageBox.Show("No puede atacar, no es su turno todavia");
            }


        }

        int x, y;

 

        private void bunifuThinButton21_MouseMove(object sender, EventArgs e)
        {
            if (boolReceive == true)
            {
                server.receiveAttack();
                boolReceive = false;
                boolAttack = true;
                this.labelAnuncio.Text = "Tu turno";
            }
        }

        private void panelInicio_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                this.Left += e.X - x;
                this.Top += e.Y - y;
            }
        }
    }
}
