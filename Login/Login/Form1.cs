using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        static Registro ventanaRegistro;
        static WindowPlataforma ventanaPlataforma;
        public Form1()
        {
            InitializeComponent();
            txtName.BackColor = DefaultBackColor;
            txtPassword.BackColor = DefaultBackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventanaRegistro = new Registro();
            ventanaRegistro.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ControllerUser controller = new ControllerUser();
            if(txtName.Text!="" && txtPassword.Text != "")
            {
                Usuario checkUser = controller.readUser(new Usuario(txtName.Text,txtPassword.Text));
                if (checkUser != null)
                {
                    ventanaPlataforma = new WindowPlataforma();
                    ventanaPlataforma
                    ventanaPlataforma.Show();

                }
            }
            else{
                MessageBox.Show("Mensaje: Verifique que ningun campo este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
