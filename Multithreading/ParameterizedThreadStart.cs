using System;
using System.Threading;
namespace Multithreading
{
    public class ParameterizedThreadStart
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("Threadpoc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Mainq()
        {
            //Thread t = new Thread(new ParameterizedThreadStart());
            //t.Start(5);
            //t.Join();
        }
    }
}
