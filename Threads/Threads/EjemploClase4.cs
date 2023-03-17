using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class EjemploClase4
    {
        static readonly string[] arrayPersonas = { "Aldo", "Brian", "Milton", "Alex" };
        static readonly object objeto = new object();
        static bool verificar = true;
        static int contador = 0;
        public static void ejecucion()
        {
            Thread hilo1 = new Thread(readPeople);
            Thread hilo2 = new Thread(readPeople);
            hilo1.Name = "ElHilaso";
            hilo2.Name = "ElSegundoHIlaso";

            hilo1.Start();
            hilo2.Start();

            while (verificar)
            {

                if (contador > 3)
                    verificar = false;

            }
            Console.WriteLine("Valor del contador= " + contador);

        }
        public static void readPeople()
        { 
            
            while (verificar)
            {
                lock (objeto) 
                {
                    Console.WriteLine("El hilo: " + Thread.CurrentThread.Name + " muestra= " + arrayPersonas[contador]);
                    contador++;
                }
            }
        }
    } 
}
