using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Threads
{
    class EjemploClase2
    {
        private static bool verificacion = true;
        private static int contador = 0;
        /*
         Existen 2 tipos de hilos
            Thread Foreground: Este tipo hilo siguen su ejecucion sin importar que el main haya terminado
            Thread Background: Este tipo de hilo termina su ejecucion hasta que el main termine
         */
        public static void ejecucion()
        {
            /*Declaracion del Hilo Foreground
            Thread hiloForeGround = new Thread(otroHiloEnEjecucion);
            hiloForeGround.Start();
            */
            /* Hilo Background*/
            Thread hiloBackGround = new Thread(otroHiloEnEjecucion);
            hiloBackGround.IsBackground = true;
            hiloBackGround.Start();

            Thread hiloMain = Thread.CurrentThread;
            hiloMain.Name = "Hilo Main";
            while (verificacion)
            {
                Console.WriteLine("Hola soy el hilo {0}", Thread.CurrentThread.Name);
                if (contador == 4)
                    verificacion = false;
                contador++;
            }

            Console.WriteLine("Termino el hilo " + Thread.CurrentThread.Name);
        }
        public static void otroHiloEnEjecucion()
        {
            Thread.CurrentThread.Name = "Otro Hilo";
            while (true)
            { 
                Console.WriteLine("Hola soy el hilo {0}", Thread.CurrentThread.Name);

            }
        }
    }
}
