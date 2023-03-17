using System;
using System.IO;
namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            using (Alumno a  = new Alumno(100,"Ale","Jandro",4))
            {
                Console.WriteLine(a);
            }


            using (TextWriter archivo = new StreamWriter("archivo.txt"))
            {
                archivo.Close();
            }
            */

            using (Alumno a = new Alumno(100, "Ale", "Jandro", 4),
                 b = new Alumno(100, "Leo", "Jandro", 4))
            {
                using (TextWriter archivo = new StreamWriter("archivo.txt"))
                {
                    archivo.WriteLine(a.mostrarInformacion());
                    archivo.WriteLine(b.mostrarInformacion());
                    archivo.Close();
                }

            }

        }
    }
}
