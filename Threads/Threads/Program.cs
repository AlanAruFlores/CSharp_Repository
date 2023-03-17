using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduccion.ejecucion();
            //EjemploClase1.ejecucion();
            //EjemploClase2.ejecucion();
            //EjemploClase3.ejecucion();
            //EjemploClase4.ejecucion();
            //Ejercicio2.execute();

           // Ejemplo3.ejecucion();

            /*
            ArchivoTexto.createFIle("texto.txt");
            ArchivoTexto.addText("Hola Mundo", "texto.txt");
            ArchivoTexto.appendText("Hola Chiques", "texto.txt");
            ArchivoTexto.appendText("Hola Chiques", "texto.txt");
            ArchivoTexto.appendText("Hola Chiques", "texto.txt");
            ArchivoTexto.appendText("Hola Chiques", "texto.txt");
            ArchivoTexto.appendText("Hola Chiques", "texto.txt");
            ArchivoTexto.appendText("Hola Chiques", "texto.txt");
            */


            ArchivoTexto.appendText("Ultima Linea","texto.txt");
            string content = ArchivoTexto.readFile("texto.txt");
            Console.WriteLine(content);

        }

    }
}
