using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        static Chat formChat;
        public Form1()
        {
            InitializeComponent();
        }
        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 8 || txtNombre.Text.Length<=0)
            {
                MessageBox.Show("No se puede exceder de los 8 caracteres o no se acepta campo vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(txtNombre.Text);
                formChat = new Chat(txtNombre.Text,"127.0.0.1");
                formChat.Show();
                this.Hide();
            }
        }

    }
}
