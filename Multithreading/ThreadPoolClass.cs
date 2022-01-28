using System;
using System.Threading;

namespace Multithreading
{
    class ThreadPoolClass
    {
        static void Mainq(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("working on thred from thred pool", s);
            });
            Console.ReadLine();
        }
    }
}
