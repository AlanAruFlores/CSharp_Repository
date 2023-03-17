using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CRUD_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente client = new Cliente();
            client.Run();
        }
    }

    class Cliente
    {

        int id = 0;
        TcpClient client;
        IPEndPoint address;
        NetworkStream stream;
        StreamReader reader;
        StreamWriter writer;

        public Cliente()
        {
            this.client = new TcpClient();
            this.address = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2200);
        }

        public void Run()
        {
            try
            {
                this.client.Connect(this.address);
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                Register();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo establecer la conexion");
            }

        }

        public void Register()
        {
            string[] data = new string[2];

            Console.WriteLine("Type your username");
            data[0] = Console.ReadLine();
            Console.WriteLine("Type your password");
            data[1] = Console.ReadLine();
            Console.WriteLine("Type your telephone");
            int telephone = int.Parse(Console.ReadLine());

            Send(data[0]);
            Send(data[1]);
            Send(telephone.ToString());
            Login();
            //new Thread(Listening).Start();
        }
        public void Login()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(reader.ReadLine());
            do
            {
                Console.WriteLine("User: ");
                string username = Console.ReadLine();
                Console.Write("\nPassword: ");
                string password = Console.ReadLine();

                Send(username);
                Send(password);

                id = int.Parse(reader.ReadLine());

            } while(id == 0);

            Console.WriteLine("Logeado con exito, su id correspondiente es {0}",id);

            new Thread(Writting).Start();
            new Thread(Listening).Start();

        }

        public void Writting()
        {
            do
            {
                writer.WriteLine(Console.ReadLine());
                writer.Flush();
            } while (true);
        }
        public void Listening()
        {
            do
            {
                Console.WriteLine(reader.ReadLine());
            } while (true);
        }


        //Simplifacacion de envio de mensaje

        private void Send(string data){ writer.WriteLine(data); writer.Flush(); }

        
    }
}
