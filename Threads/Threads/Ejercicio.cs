using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    //Dar un ejemplo de la programacion nmultihilos o concurrente
    class Ejercicio
    {
        private static string[] listaPersonas = new string[2];
        private static string[] listaMascotas = new string[2];

        private static bool relleno = false;

        //Ejercicio

        private static void rellenarLista()
        {
            Thread.Sleep(10000);
            listaPersonas[0] ="Pepe";
            listaPersonas[1] ="Juan";
            relleno = true;

        }
        private static void mostrarPersonas()
        {
            if (relleno == true)
            {
                foreach (string persona in listaPersonas)
                {
                    Console.WriteLine(persona);
                }
            }
            else
            {
                Console.WriteLine("NO EXISTE NINGUNA PERSONA REGISTRADA");
            }

        }
        public static void ejecucion()
        {
            Thread hiloDB = new Thread(rellenarLista);
            hiloDB.Start();

            int opcion;
            do
            {
              
                Console.WriteLine("-----MENU--------");
                Console.WriteLine("[0] VER DATOS");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 0)
                {
                    mostrarPersonas();
                }
            } while (true);


        }

        //Otro ejercicio
        private static readonly object objeto = new object();
        public static void ejecucion2()
        {
            rellenarArrays();
            Thread hiloPersona = new Thread(()=>mostrarLista(listaPersonas));
            Thread hiloMascota = new Thread(()=>mostrarLista(listaMascotas));
            hiloPersona.Start();
            hiloMascota.Start();
        }

        private static void rellenarArrays()
        {
            listaPersonas[0] = "Juan";
            listaPersonas[1] = "Pepe";

            listaMascotas[0] = "Slash";
            listaMascotas[1] = "Jackson";
        }
        private static void mostrarLista(string[] lista)
        {
            lock (objeto)
            {
                foreach (string obj in lista)
                {
                    Console.WriteLine(obj);
                    Thread.Sleep(1000);
                }
            }
        }

    }
}
