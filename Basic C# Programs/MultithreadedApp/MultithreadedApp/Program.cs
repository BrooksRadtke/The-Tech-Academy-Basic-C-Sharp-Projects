using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starts:");

            // Start execution time
            Stopwatch watch = new Stopwatch();
            watch.Start();

            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);

            //Method1();
            //Method2();
            //Method3();

            t1.Start();
            t2.Start();
            t3.Start();

            // Call the Join method for each thread so that the main thread does not exit until
            // all three threads are finished executing
            t1.Join();
            t2.Join();
            t3.Join();

            // Stop execution time
            watch.Stop();

            // Print result
            Console.WriteLine(watch.ElapsedMilliseconds);

            Console.WriteLine("Main thread ends:");
            Console.ReadKey();
        }

        // Example of Singlethread method
        public static void Method1()
        {
            Console.WriteLine("Method1 Starts:");

            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Method1 " + i);
            }

            Console.WriteLine("Method1 Ends:");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 Starts:");

            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Method2 " + i);

                if(i ==25)
                {
                    //Console.WriteLine("Main thread is going to sleep -_-");
                    Console.WriteLine("Thread t2 is going to sleep -_-");
                    Thread.Sleep(5000);

                    //Console.WriteLine("Main thread is awake 0_0");
                    Console.WriteLine("Thread t2 is awake 0_0");
                }
            }

            Console.WriteLine("Method2 Ends:");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3 Starts:");

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Method3 " + i);
            }

            Console.WriteLine("Method3 Ends:");
        }
    }
}
