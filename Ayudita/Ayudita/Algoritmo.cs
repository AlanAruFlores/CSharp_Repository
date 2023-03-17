using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Ayudita
{
    public class Algoritmo
    {
        static int[] vector = new int[80]; 
        public static void ejecutarPrograma()
        {
            //Crea el archivo llamado "archivoVectorial" en formato txt
            crearArchivo(@"archivoVectorial.txt");
            //Genero numeros aleatorios y los guarda en el archivo
            escribirArchivo(@"archivoVectorial.txt");
            //Lee el archivo
            leerArchivo(@"archivoVectorial.txt");



            /*Aca se ingresa el dato a buscar y se muestra las veces que se ubica
             dentro del archivo.
             */
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Escriba un dato a buscar en el archivo");
            string dato = Console.ReadLine();
            int contador = buscarDato(@"archivoVectorial.txt", dato);

            Console.WriteLine("Se encontro {0} veces el dato {1}", contador,dato);

        }

        /*
         * Encargado de crear el archivo txt.
         */
        public static void crearArchivo(string name)
        {
            TextWriter archivoCreado = new StreamWriter(name);
            archivoCreado.Close();
            if (File.Exists(name))
                Console.WriteLine("El archivo de texto ya existe");
        }
        /*
         * Encargado de generar numeros aleatorios y añadirlo el Archivo
         * @param: nombre del Archivo
         * @return: nada 
         */
        public static void escribirArchivo(string ruta)
        {
            TextWriter archivo = new StreamWriter(ruta);
            for (int i = 0; i < 80; i++)
            {
                vector[i] = new Random().Next(0, 10);
                archivo.WriteLine(vector[i]);
            }
            archivo.Close();
        }
        /*
         *Encargado de leer el archivo txt
         *@param: nombre del arhivo a leer
         *@return: nada
         */

        public static void leerArchivo(string nombreArchivo)
        {
            try
            {
                int cont = 0;
                string line = "";
                TextReader archivoLectura = new StreamReader(nombreArchivo);

                //Evaluo se la condicion cumple, permite leer las 20 lineas
                while((line = archivoLectura.ReadLine()) != null && cont < 20)
                {
                    Console.WriteLine(line);
                    cont++;
                }
                archivoLectura.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         *Metodo encargado de buscar un dato, recorre linea por linea
         *del archivo txt.
         *@param: nombre archivo, dato a buscar.
         *@return: contador.
         */
        public static int buscarDato(string nombreArchivo, string dato)
        {
            int contador = 0;
            try
            {
                TextReader archivoLectura = new StreamReader(nombreArchivo);
                string linea = "";
                while((linea = archivoLectura.ReadLine()) != null)
                {
                    if (linea == dato) // Ve si el dato es identico.
                        contador++;
                }
                archivoLectura.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return contador;
        }


    }
}
