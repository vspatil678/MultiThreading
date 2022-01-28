using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class TaskExample1
    {
        static void Main1(string[] args)
        {
            Task t =  Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("print {0}", i);
                }
            });
            t.Wait(); // we cant t.Start() because Task is already started when we invoke 
            // Task.Run() method
        }
    }
}
