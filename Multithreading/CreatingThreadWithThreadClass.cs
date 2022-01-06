using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
   public class CreatingThreadWithThreadClass
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Threadpoc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread do some work");
                Thread.Sleep(1000);
            }
            t.Join();
        }
    }
}
