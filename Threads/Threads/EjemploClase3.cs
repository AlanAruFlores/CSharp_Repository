using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class EjemploClase3
    {
        static int contador = 0;
        static bool ejecutar = true;
        static object objeto = new object();
        public static void ejecucion()
        {
            Thread hilo1 = new Thread(IncrementarContador);
            Thread hilo2 = new Thread(IncrementarContador);


            hilo1.Name = "Hilo1";
            hilo2.Name = "Hilo2";


            hilo1.Start();
            hilo2.Start();

            while (ejecutar)
            {
                if (contador > 40)
                    ejecutar = false;
            }
        }
        public static void IncrementarContador()
        {
            while (ejecutar)
            {
                lock(objeto)
                {
                    contador++;
                    Console.WriteLine("El Hilo {0} tiene el contador: {1}", Thread.CurrentThread.Name, contador);
                    Thread.Sleep(1000);
                }

            }
        }

    }
}
