using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
namespace Threads
{
    class P_HiloMain
    {

        static List<Usuario> listaUsuarios;

        public static void main()
        {
            listaUsuarios = new List<Usuario>();

            Thread miHilo = new Thread(() =>
            {
                showMenu();
            });

            loadResource();
            miHilo.Start();
            miHilo.Join();




        }

        public static void loadResource()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cargando Recursos.......");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void showMenu()
        {
            int option=0;

            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------------MEMU----------------");
                    Console.WriteLine("\n[1]MOSTRAR PERSONAS" +
                        "\n[2]REGISTRAR PERSONAS" +
                        "\n[3]SALIR");
                    option = int.Parse(Console.ReadLine());
                } while (option < 1 || option > 3);

                seeingOption(option);





            } while (option != 3);
        }

        public static void seeingOption(int option)
        {
            switch (option)
            {
                case 1:
                        Console.WriteLine("CARGANDO DATOS....");
                        Thread.Sleep(4000);
                        Console.WriteLine("MOSTRANDO USUARIOS: ");
                        foreach (Usuario user in listaUsuarios)
                        {
                            Console.WriteLine(user);
                        }
                    break;
                case 2:
                {
                      string nombre, email;
                      int edad;

                            Console.WriteLine("DIGITE SU NOMRBE");
                            nombre = Console.ReadLine();
                            Console.WriteLine("DIGITE SU MAIL ");
                            email = Console.ReadLine();
                            Console.WriteLine("DIGITE SU EDAD");
                            edad = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enviendo datos....");
                                Thread.Sleep(2000);
                                Console.WriteLine("Actualizado");
                                listaUsuarios.Add(new Usuario(nombre, edad, email));

                    }
                    break;
                default:
                    Console.WriteLine("Saliendo....");
                    Thread.Sleep(4000);
                    break;
            }

        }
    }
}
