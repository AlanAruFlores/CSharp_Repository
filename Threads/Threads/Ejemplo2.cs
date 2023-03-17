using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class Ejemplo2
    {

        public const int exponente = 4;
        
        public static void ejecucion()
        {
            Ejemplo2 obj = new Ejemplo2();

            Thread miHilo = new Thread(obj.realizarPotencia);
            miHilo.Name = "Hilo1";
            miHilo.Start();

            Thread.CurrentThread.Name = "Hilo Main";
            obj.realizarPotencia();


        }
        


        public void realizarPotencia()
        {
            int numeroLocal = 0;
            if (Thread.CurrentThread.Name.Contains("Hilo1"))
                numeroLocal = 4;
            else
                numeroLocal = 2;

            Console.WriteLine("El hilo " + Thread.CurrentThread.Name + ", su resultado es: " + Math.Pow(numeroLocal,exponente));
    
        }
    }
}
