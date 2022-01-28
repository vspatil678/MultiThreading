using System;
using System.Threading;

namespace Multithreading
{
    public class BackgroundThread
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Threadpoc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void Main1(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            t.IsBackground = false;
        }
    }
}
