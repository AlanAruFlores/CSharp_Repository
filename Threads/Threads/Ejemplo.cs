using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class Ejemplo
    {
        public static bool iterando = true;
        public static int contador = 0;
        public static object objeto = new object();

        public static void ejecucion()
        {
            Thread miHilo = new Thread(realizarOperacion);
            miHilo.IsBackground = true;
            miHilo.Name = "Hilo 1";
            miHilo.Start();

            Thread.CurrentThread.Name = "Hilo Main";

            while (iterando)
            {
                if (contador >= 10)
                    iterando = false;
            }
            Console.WriteLine("Saliendo del main");

        }

        public static void realizarOperacion()
        {
            while (true)
            {
                Console.WriteLine("Hola desde el hilo: " + Thread.CurrentThread.Name);
                contador++;    
            }
        }
    }
}
