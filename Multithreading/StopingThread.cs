using System;
using System.Threading;

namespace Multithreading
{
    public class StopingThread
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Threadpoc: {0}", i);
                Thread.Sleep(0);
            }
        }


        public static void Mainq()
        {
            bool isStoped = false;

            Thread t = new Thread(new ThreadStart(() => { 
                while(!isStoped)
                {
                    Console.WriteLine("Thread is Running");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
            isStoped = true;
            t.Join();
            
        }
    }
}
