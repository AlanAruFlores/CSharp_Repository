using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ayudita
{
    class Algoritmo2
    {
        /*Dado un vector de 80 posiciones, hacer que se cargue cada uno de los campos entre 5 y 500 usando 3 hilos. 
 Luego  realizar un metodo que genere 3 hilos de manera automatica  y que imprima por pantalla los valores que 
sean multiplos de 2*/
        static int i = 0;
        static int[] vector = new int[80];
        static void ejecutarPrograma()
        {
            bool value = true;
            Thread threadIncremento;

            for (int j = 0; j < 3; j++)
            {
                threadIncremento = new Thread(incrementarCampo);
                threadIncremento.Start();
            }

            while (value == true)
            {
                if (i >= 80)
                {
                    Thread threadImpresion;
                    for (int j = 0; j < 3; j++)
                    {
                        threadImpresion = new Thread(mostrarNumeros);
                        threadImpresion.Start();
                    }
                    value = false;
                }
            }

        }
        static void incrementarCampo()
        {
            while (i < vector.Length)
            {
                vector[i] = new Random().Next(5, 500);
                i++;

            }
            //Thread.CurrentThread.Abort();
        }
        static void mostrarNumeros()
        {
            i = 0;
            while (i < vector.Length)
            {
                if (vector[i] % 2 == 0)
                {
                    Console.WriteLine("MULTIPLO DE 2:{0}", vector[i]);
                }
                i++;
            }
            //Thread.CurrentThread.Abort();
        }
    }
}
