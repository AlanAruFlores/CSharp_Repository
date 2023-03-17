using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class Introduccion
    {
        public static void ejecucion()
        {
            //Este hilo se crea de forma automatica, por lo que anteriormente siempre estuvimos trabajando con un hilo
            //Por eso mismo si teniamos una instruccion sin terminar, la siguiente no se podria ejecutar
            //Pero gracias a los hilos se puede evitar este incoveniente
            Thread hiloMain = Thread.CurrentThread;
            hiloMain.Name = "HiloPrincipal";
            Console.WriteLine("El hilo actual es: {0}", hiloMain.Name);
        }


    }
}
