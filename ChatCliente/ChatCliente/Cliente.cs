using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace ChatCliente
{
    class Cliente
    {
        public NetworkStream flujo;
        public StreamWriter flujoEscritura;
        public StreamReader flujoLectura;

        public TcpClient usuario = new TcpClient();
        private static string nombre;
        private static string ip;
        public static Chat chatCliente;
        public static RichTextBox chatSection;
        public Cliente(string nombre, Chat chat, RichTextBox chatSection, string ip)
        {
            Cliente.nombre = nombre;
            Cliente.chatCliente = chat;
            Cliente.chatSection = chatSection;
            Cliente.ip = ip;
            start();
        }


        public void escribiendo(string msj, RichTextBox rch)
        {
            try
            {
                flujoEscritura.WriteLine(msj);
                flujoEscritura.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar mensaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void recibiendo()
        {
            while (usuario.Connected)
            {
                try
                {
                    string msj = flujoLectura.ReadLine();
                    if (msj.Contains("close")) chatCliente.botonCerrarAlternativa();
                    else chatSection.Text += msj + "\n";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo recibir mensaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void start()
        {
            try
            {
                usuario.Connect(ip, 2134);
                flujo = usuario.GetStream();
                flujoEscritura = new StreamWriter(flujo);
                flujoLectura = new StreamReader(flujo);

                flujoEscritura.WriteLine(nombre);
                flujoEscritura.Flush();
                new Thread(recibiendo).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion no establecida", "Error con la direccion ip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void cerrar()
        {
            try
            {
                flujoEscritura.WriteLine("exit");
                flujoEscritura.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getNombre()
        {
            return nombre;
        }

    }



}