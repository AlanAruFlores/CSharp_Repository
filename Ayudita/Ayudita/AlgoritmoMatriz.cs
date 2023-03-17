using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Ayudita
{
    class AlgoritmoMatriz
    {
        static int [,]array;
        static int contador = 1;
        /*DADA UNA MATRIZ N*M ALMACENAR CADA FILA EN UN ARCHIVO LLAMADO CARGA.TXT*/
        public static void ejecutarPrograma()
        {
            Console.WriteLine("Write the amount of rows: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Write the amount of columns: ");
            int c = int.Parse(Console.ReadLine());
            array = new int[r,c];

            createAndWriteFile(r, c);

            Console.WriteLine("Enter the number of the row to show: ");
            int n = int.Parse(Console.ReadLine());
            printFileToConsole(n);


        }
        static void putValues(int r, int c, StreamWriter file)
        {
            for (int i = 0; i < r; i++)
                for (int k = 0; k < c; k++)
                {
                    array[i, k] = new Random().Next(1, 10);
                    if (k == (c-1))
                        file.WriteLine(array[i, k]);
                    else
                        file.Write(array[i, k] + " ");
                }
                
        }

        static void createAndWriteFile(int r, int c)
        {
            TextWriter txt = new StreamWriter(@"array.txt");
            putValues(r, c, (StreamWriter)txt);
            txt.Close();
        }

        static void printFileToConsole(int n)
        {
            try
            {
                TextReader txt = new StreamReader(@"array.txt");
                string line="";
                while((line = txt.ReadLine()) != null)
                {
                    if(contador == n)
                    {
                        Console.WriteLine(line);
                    }
                    contador++;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
