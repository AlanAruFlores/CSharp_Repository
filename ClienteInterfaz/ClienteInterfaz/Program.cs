using System;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ClienteInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente.Iniciar();
        }
    }
    class Cliente
    {

        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        static private string nick = "Anonimo";

        static public void enviarMensaje(string mensaje)
        {
            streamw.WriteLine(mensaje);
            streamw.Flush();
        }

        static void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    Console.WriteLine(streamr.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No se pudo conectar con el servidor, presione una tecla para salir.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }



        static void Conectar(string ip, int puerto)
        {
            try
            {
                client.Connect(ip, puerto);
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);

                    streamw.WriteLine(nick);
                    streamw.Flush();

                    t.Start();
                }
                else
                {
                    Console.WriteLine("No se pudo conectar con el servidor, presione una tecla para salir.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo conectar con el servidor, presione una tecla para salir.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public static void interfazChat()
        {
            Console.Clear();
            Console.WriteLine("Conexión exitosa! ya puede escribir en el chat");
            do
            {
                enviarMensaje(Console.ReadLine());
            } while (true);
        }

        public static string pedirIP()
        {
            string ip = "127.0.0.1";
            Console.Clear();
            Console.Write("Ingrese la ip del servidor: "); ip = Console.ReadLine();
            return ip;
        }

        public static int pedirPuerto()
        {
            int puerto = 8000;
            try
            {
                Console.Clear();
                Console.Write("Ingrese puerto del servidor (8000): "); puerto = int.Parse(Console.ReadLine());
            }
            catch { }

            return puerto;
        }




        public static void Iniciar()
        {
            string respuesta = "y";
            Console.WriteLine("Digite el nombre del usuario: ");
            nick = Console.ReadLine();

            Console.WriteLine("El servidor está en la misma PC? (y/n)");
            respuesta = Console.ReadLine();
            if (respuesta == "y")
            {
                Conectar("127.0.0.1", 2134);
            }
            else
            {
                Conectar(pedirIP(), pedirPuerto());
            }

            interfazChat();
        }
    }
}
