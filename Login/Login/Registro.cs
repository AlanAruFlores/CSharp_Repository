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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            txtName.BackColor = DefaultBackColor;
            txtPassword.BackColor = DefaultBackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ControllerUser controller = new ControllerUser();
            if(txtName.Text != "" && txtPassword.Text != "")
            {
                controller.createUser(new Usuario(txtName.Text, txtPassword.Text));
            }
            else
            {
                MessageBox.Show("Mensaje: Verifique que los campos esten llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
