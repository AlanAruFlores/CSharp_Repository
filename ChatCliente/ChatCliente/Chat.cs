using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ChatCliente
{
    public partial class Chat : Form
    {
        static Cliente cliente;
        public Chat(string nombre, string ip)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            richChat.ReadOnly = true;
            new Thread(() =>
            {
                Chat.cliente = new Cliente(nombre,this, this.richChat,ip);
            }).Start();

            labelUsuario.Text = "Chat de " + nombre;
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (textMensaje.Text != "")
            {
                cliente.escribiendo(textMensaje.Text, richChat);
                textMensaje.Text = "";
            }
        }

        public void botonCerrarAlternativa()
        {
            MessageBox.Show("Te expulsaron "+cliente.getNombre());
            this.Hide();
        }

        public void botonCerrar_Click_1(object sender, EventArgs e)
        {
            new Thread(Chat.cliente.cerrar).Start();
            this.Hide();
        }
    }
}
