using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows;

namespace TurnosServidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Servidor server = new Servidor("127.0.0.1", 2400);
            server.StartServer();
        }
    }

    class Servidor
    {
        TcpListener server; 
        List<Client> listClients;
        Client actualClient;
        List<Turno> listTurnos;
        Archivo turnoTXT;
        
        struct Turno
        {
            static int cont = 0;
            public int id { get; set; }
            public string userName { get; set; }
            public DateTime date { get; set; }
            public string content { get; set; }

            
            public Turno(string userName)
            {
                this.id = ++cont;
                this.userName = userName;
                this.date = new DateTime();
                this.content = "";
            }

            public void GeneratingContent()
            {
                this.content = "-----TURNO-------" +
                    "\nTurno ID: "+this.id +
                    "\nUsuario: " + this.userName + "" +
                    "\nFecha: " + this.date.ToString() + "" +
                    "\n-------------------";
            }
            public void GeneratingTime() {
                this.date = new DateTime(GettingYear(), GettingMonth(), GettingDay());
            }

            private int GettingYear() => new Random().Next(2022, 2024);
            private int GettingMonth() => new Random().Next(1, 12);
            private int GettingDay() => new Random().Next(1, 30);

            

        }
        struct Client {
            public string nombre { get; set; }
            public NetworkStream network { get; set; }
            public StreamReader readStream { get; set; }
            public StreamWriter writeStream { get; set;  }

            //public List<Turno> listTurnos { get;}
            public Client(NetworkStream clientStream)
            {
                this.network = clientStream;
                this.readStream = new StreamReader(network);
                this.writeStream = new StreamWriter(network);
                this.nombre = "";
                //this.listTurnos = new List<Turno>();
            }
            /*
            public void setTurno(Turno turno)
            {
                listTurnos.Add(turno);
            }
            */
        }
        public Servidor(string ip, int port)
        {
            server = new TcpListener(IPAddress.Parse(ip), port);
            listClients = new List<Client>();
            listTurnos = new List<Turno>();
            turnoTXT = new Archivo();
            turnoTXT.CreateFile("turnos.txt");
        }

        public void StartServer()
        {
            try
            {
                server.Start();
                new Thread(ListeningClients).Start();
                new Thread(ReadingFile).Start();
            } catch (Exception ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
        }
        public void ReadingFile()
        {
            do
            {
                Console.WriteLine("INGRESE LA PALABRA 'LEER' PARA LEER EL ARCHIVO");
                string input = Console.ReadLine();
                input = input.ToUpper();
                if (input.Equals("LEER"))
                {
                    string result = turnoTXT.ReadingFileContent("turnos.txt");
                    Console.WriteLine(result);
                }

            } while (true);

        }
        public void ListeningClients()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Esperando Conexiones....");
            do
            {
                TcpClient  client = server.AcceptTcpClient();
                actualClient = new Client(client.GetStream());
                actualClient.nombre = actualClient.readStream.ReadLine();
                listClients.Add(actualClient);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Se conecto el usuario '{0}'", actualClient.nombre);
                new Thread(Listening).Start();
            } while (true);
        }
        public void Listening()
        {
            Client cliente = actualClient;
            
            do
            {
                try
                {
                    string message = cliente.readStream.ReadLine();
                    Console.WriteLine(message);
                    message = message.ToUpper();
                    if (message.Equals("TURNO"))
                    {
                        Turno turnoNuevo = new Turno(cliente.nombre);
                        turnoNuevo.GeneratingTime();
                        turnoNuevo.GeneratingContent();
                        turnoTXT.WriteFile("turnos.txt", turnoNuevo.content);
                        listTurnos.Add(turnoNuevo);
                       // cliente.setTurno(turnoNuevo);
                        cliente.writeStream.WriteLine(turnoNuevo.id);
                       cliente.writeStream.Flush();
                    }
                }
                catch 
                {
                    Console.WriteLine("El {0} se desconecto", cliente.nombre);
                    listClients.Remove(cliente);
                    break;
                }
            } while (true);
        }
    }


    class Archivo
    {
        public void CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
                File.Create(fileName);
            TextWriter tw = new StreamWriter(fileName, false);
            tw.Write(string.Empty);
            tw.Close();
        }
        public void WriteFile(string fileName, string content)
        {
            TextWriter writerFile = File.AppendText(fileName);
            writerFile.WriteLine(content);
            writerFile.Close();
        }

        public string ReadingFileContent(string fileName)
        {
            string contentFile = "";
            try
            {
                TextReader readFile =  new StreamReader(fileName);
                string line = "";
                while((line = readFile.ReadLine()) != null)
                {
                    contentFile += line+"\n";
                }
                readFile.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return contentFile;
        }
         
    }
}
