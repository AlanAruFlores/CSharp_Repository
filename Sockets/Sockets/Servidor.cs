using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    class Servidor
    {
        IPEndPoint ip;
        Socket socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket socketCliente;

        public Servidor()
        {
            ip = new IPEndPoint(IPAddress.Any, 4000);
            conectar();

        }
        public void conectar()
        {
            try
            {
                socketServer.Bind(ip);
                socketServer.Listen(1);
                Console.WriteLine("Server Conectado");
                socketCliente = socketServer.Accept();
                Console.WriteLine("Cliente connectado");
                escuchar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public void escuchar()
        {
            byte[] bytes = new byte[255];
            do
            {

                socketCliente.Receive(bytes, 0, bytes.Length, 0);
                Array.Resize(ref bytes, bytes.Length);
                string mensaje = Encoding.Default.GetString(bytes);

                string contador = contar(mensaje).ToString();
                byte[] bytesEnviar = Encoding.Default.GetBytes(contador);
                socketCliente.Send(bytesEnviar);

            } while (socketCliente.Connected);
        }
        public int contar(string mensaje)
        {
            int contador = 0;
            for (int i = 0; i < mensaje.Length; i++)
            {
                if (mensaje[i] == 'a' || mensaje[i] == 'A')
                    contador++;
            }
            return contador;
        }
    }
}
