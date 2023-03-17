using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;
using Controller;
namespace CRUD_Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Servidor server = new Servidor();
            server.Run();
        }
    }

    class Servidor
    {
        List<Users> listUsers;
        TcpListener listener;
        IPEndPoint ip;
        Users user;


        public Servidor()
        {
            listUsers = new List<Users>();
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2200);
            listener = new TcpListener(ip);
            user = null;
        }

        public void Run()
        {
            try
            {
                listener.Start();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El servidor se establecio con exito");
                new Thread(Writting).Start();
                ListeningConnections();

            }
            catch (Exception ex)
            {
                Console.WriteLine("El servidor no se pudo Conectar");
            }
        }
        public void ListeningConnections()
        {
            TcpClient client;
            do
            {
                //Parte del regitro
                client = listener.AcceptTcpClient();
                user = new Users(client.GetStream());
                listUsers.Add(user);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Se conecto un usuario con exito");

                new Thread(TypingnData).Start();
                //new Thread(ListeningRequests).Start();
            } while (true);
        }
        public void TypingnData()
        {
            Users userActual = user;
            string username = userActual.reader.ReadLine();
            string password = userActual.reader.ReadLine();
            int telephone = int.Parse(userActual.reader.ReadLine());
            ControllerUser.Register(username, password, telephone);

            //Login
            userActual.writer.WriteLine("Se registro su cuenta con exito.Ingrese sus datos en el login");
            userActual.writer.Flush();
            ValidatingLogin();
        }
        public void ValidatingLogin()
        {
            Users userActual = user;
            string username="", password="";
            int idValue = 0;
            do
            {
                username = userActual.reader.ReadLine();
                password = userActual.reader.ReadLine();
                idValue = ControllerUser.Login(username, password);
                userActual.writer.WriteLine(idValue);
                userActual.writer.Flush();
            } while (idValue == 0);

            userActual.id = idValue;
            string content = ControllerProduct.SeeProducts();
            userActual.writer.WriteLine(content);
            userActual.writer.Flush();
            new Thread(ListeningRequests).Start();
      
        }
        public void ListeningRequests()
        {
            Users userActual = user;
            int data;

            do
            {
                try
                {
                    string request = userActual.reader.ReadLine();
                    if (int.TryParse(request, out data))
                    {
                        bool value = ControllerVentas.RegisterNewVenta(userActual.id, data);

                        if (value) userActual.writer.WriteLine("Venta generada");
                        else userActual.writer.WriteLine("Venta no generada :,v");
                    }
                    Console.WriteLine(request);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (true);
        }

        public void Writting()
        {
            do
            {
                string message = Console.ReadLine();
                
                if (message.Equals("ver ventas")) Console.WriteLine(ControllerVentas.ShowVentas());
                if (message.Equals("pdf")) PDFController.GeneratePDFDocument();



            } while (true);
        }



    }
    class Users
    {
        public int id { get; set; }
        public NetworkStream stream { get; set; }
        public StreamReader reader { get; set; }
        public StreamWriter writer { get; set; }

        public Users(NetworkStream streamclient)
        {
            this.stream = streamclient;
            this.reader = new StreamReader(stream);
            this.writer = new StreamWriter(stream);
        }
    }

}
