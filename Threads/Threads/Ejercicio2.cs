using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class Ejercicio2
    {
        static int count = 0;
        static bool value = false;
        static object thread = new object();
        public static void execute()
        {
            Thread threadNumberOne = new Thread(increaseCountVariable);
            Thread threadNumberTwo = new Thread(increaseCountVariable);
            Thread threadNumberThree = new Thread(increaseCountVariable);
            threadNumberOne.Name = "Thread One";
            threadNumberTwo.Name = "Thread Two";
            threadNumberThree.Name = "Thread Three";
            threadNumberOne.Start();
            threadNumberTwo.Start();
            threadNumberThree.Start();



            while (value == false)
            {
                if (count >= 5000)
                {
                    value = true;
                    Console.WriteLine("Count reach to "+count);
                }
            }
        }

        public static void increaseCountVariable()
        {
            while(count <= 5000)
            {
                    Console.WriteLine(Thread.CurrentThread.Name + " -> " + count);
                    Ejercicio2.count++;

                
            }

        }

    }
}
