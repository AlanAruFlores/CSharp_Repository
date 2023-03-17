using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class Ejemplo3
    {
        static readonly int[] dinero = {400,200,600};
        static readonly string[] cbus = { "Pepe", "Juan", "Pedro" };

        public static void ejecucion()
        {
            Thread hiloSaldos = new Thread(()=>{
                Console.ForegroundColor = ConsoleColor.Red;
                mostrarDinero();
            });

            Thread hiloCBUS = new Thread(() =>
            {
                Console.ForegroundColor = ConsoleColor.White;
                mostrarCbus();
            });

            hiloCBUS.Start();
            hiloCBUS.Join();
            hiloSaldos.Start();


        }


        public static void mostrarCbus()
        {
            Console.WriteLine("-------------CBUS--------------");
            foreach(string cbu in cbus)
            {
                Console.WriteLine("CBU " + cbu);
            }
        }

        public static void mostrarDinero()
        {
            Console.WriteLine("----------------DINERO---------------------");
            foreach(int money in dinero)
            {
                Console.WriteLine("SALDO: $" + money);
            }
        }


    }
}
