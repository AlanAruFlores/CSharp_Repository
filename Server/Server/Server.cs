using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace Server
{
    class Server
    {
        private TcpListener escuchador;
        private TcpClient cliente;
        private IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 4048);
        private List<Connection> conexiones = new List<Connection>();


        public Server()
        {
            this.Iniciar();
        }

        Connection conexionActual;
        struct Connection
        {
            public NetworkStream datosRed { get; }
            public StreamWriter escribir { get; }
            public StreamReader leer { get; }
            public string nombreUsuario { get; set; }
            public Connection(TcpClient client)
            {
                this.datosRed = client.GetStream();
                this.escribir = new StreamWriter(this.datosRed);
                this.leer = new StreamReader(this.datosRed);
                this.nombreUsuario = leer.ReadLine();
            }
        }
        public void Iniciar()
        {
            Console.WriteLine("Servidor Conectado");
            escuchador = new TcpListener(direccion);
            escuchador.Start();
            while (true)
            {
                cliente = escuchador.AcceptTcpClient();
                conexionActual = new Connection(cliente);
                conexiones.Add(conexionActual);
                Console.WriteLine("Se conecto el usuario: " + conexionActual.nombreUsuario);
                Thread hilo = new Thread(Escuchando);
                hilo.Start();
            }

        }

        public void Escuchando()
        {
            do
            {
                try
                {
                    string msj = conexionActual.nombreUsuario + ": " + conexionActual.leer.ReadLine();
                    Console.WriteLine(msj);
                    foreach (Connection conn in conexiones)
                    {
                        conn.escribir.WriteLine(msj);
                        conn.escribir.Flush();
                    }
                }
                catch
                {
                    conexiones.Remove(conexionActual);
                    Console.WriteLine("Se ha desconectado: " + conexionActual.nombreUsuario);
                    break;
                }
            } while (true);
        }
    }
}
//------------------------------------------------------------------------
//Socket miServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 4048);
//Socket miCliente;
//List<Socket> clientes = new List<Socket>();
//public Server()
//{
//    miServidor.Bind(direccion);
//    miServidor.Listen(8);
//    while (true)
//    {
//        new Thread(() =>
//        {
//            obtenerConexion();
//        }).Start();
//    }
//}
//public void obtenerConexion()
//{
//    try
//    {
//        miCliente = miServidor.Accept();
//        clientes.Add(miCliente);
//        Console.WriteLine("Se conecto otro cliente");
//    }
//    catch (Exception error)
//    {
//        Console.WriteLine(error.Message);
//    }
//}

//public void start()
//{
//    byte[] buffer;
//    string mensaje;
//    do
//    {
//        Console.WriteLine("Esperando Mensajes....................");
//        buffer = new byte[255];
//        int nroBytesRecibidos = miCliente.Receive(buffer, 0, buffer.Length, 0);
//        Array.Resize(ref buffer, nroBytesRecibidos);
//        mensaje = Encoding.Default.GetString(buffer);
//        cerrarConexion(mensaje);
//    } while (mensaje.ToLower() != "exit");
//    miServidor.Close();
//    Console.WriteLine("Sevidor Cerrado");
//    Console.ReadKey();
//}
//public void cerrarConexion(string mensaje)
//{
//    if (mensaje.ToLower() != "exit")
//    {
//        byte[] bytes = Encoding.Default.GetBytes("Se Recibio el mensaje");
//        miCliente.Send(bytes);
//        Console.WriteLine("mensaje recibido = " + mensaje);
//    }
//}  