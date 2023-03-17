using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;
namespace TurnosCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DIGITE UN NOMBRE USUARIO");
            string userName = Console.ReadLine();
            Console.Clear();
            Cliente cliente = new Cliente(userName);
            cliente.Start();
        }
    }

    class Cliente
    {
        NetworkStream network;
        StreamReader readNetwork;
        StreamWriter writeNetwork;
        string userName;
        List<string> listTurnos;
        TcpClient client;
        public Cliente(string userName)
        {
            this.userName = userName;
            this.listTurnos = new List<string>();
            this.client = new TcpClient();
        }

        public void Start()
        {
            try
            {
                client.Connect(IPAddress.Parse("127.0.0.1"), 2400);
                this.network = client.GetStream();
                readNetwork = new StreamReader(this.network);
                writeNetwork = new StreamWriter(this.network);
                writeNetwork.WriteLine(this.userName);
                new Thread(Writting).Start();
                new Thread(Listening).Start();

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error al conectarse con el servidor");
            }
        }

        public void Writting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Puede empezar a escribir");
            do
            {
                string data = Console.ReadLine();
                Console.WriteLine(userName + ": " + data);
                writeNetwork.WriteLine(data);
                writeNetwork.Flush();
            } while (client.Connected);
        }
        public void Listening()
        {

            do
            {
                string result = readNetwork.ReadLine();
                if(result != null || result != "")
                {
                    Console.WriteLine(result);
                    listTurnos.Add(result);
                }
            } while (client.Connected);
        }



    }
}
