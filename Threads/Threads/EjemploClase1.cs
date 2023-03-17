using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class EjemploClase1
    {
        //Ahora mismo vamos a ver como definir un hilo en nuestro programa
        public static void ejecucion()
        {

            Thread hiloNuevo = new Thread(ejecutarTarea);
            hiloNuevo.Start();
            
                Thread hiloMain = Thread.CurrentThread;
                Console.ForegroundColor = ConsoleColor.Red;
                hiloMain.Name = "Hilo Main";
                Console.Write("Este es el hilo: {0}", hiloMain.Name);
            

        }

        public static void ejecutarTarea()
        {
            
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.CurrentThread.Name = "Hilo Nuevo";
                Console.Write("Hola soy el hilo {0}", Thread.CurrentThread.Name);
            
        }
    }
}
