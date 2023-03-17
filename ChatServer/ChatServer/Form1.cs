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

namespace ChatServer
{
    public partial class Form1 : Form
    {

        Sevidor servidorActual;
        Email email;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            servidorActual = new Sevidor(this);
            email = new Email();
            new Thread(() => servidorActual.Iniciar()).Start();
        }
        public void actualizarRegistro()
        {
            if(labelLista.Text != "") labelLista.Text = "";
            List<Connection> conexiones = servidorActual.getConexiones();
            foreach(Connection user in conexiones)
            {
                labelLista.Text += "\n"+user.id+"-"+user.nombreUsuario;
            }
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                email.enviarMensaje();
            }).Start();
        }

        private void botonCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            if (id == "") MessageBox.Show("No se aceptan datos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else new Thread(()=>servidorActual.eliminarUsuario(id)).Start(); 
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
