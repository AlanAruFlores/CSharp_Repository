using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class ConversacionServerForms : Form
    {
        static Server server;
        public ConversacionServerForms()
        {
            InitializeComponent();
        }
        public void establecerConexion()
        {
            server = new Server();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (txtPersonaje.Text.Length > 0)
            {
                establecerConexion();
                server.Start(txtPersonaje.Text,mensajePersonaje, labelInformation);
            }
            else
            {
                MessageBox.Show("Advertencia", "No se aceptan mensajes vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
