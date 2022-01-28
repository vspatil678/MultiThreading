using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading
{
    class TaskWaitAll
    {
        static void Mains(string[] args)
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Task 0");
                return 1;
            }) ;

            tasks[1] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Task 1");
                return 1;
            });

            tasks[2] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Task 2");
                return 1;
            });

            Task.WaitAll(tasks);

        }
    }
}

// all 3 tasks are executed simultaneously , and the whole run takes approximately 1000 ms
// instead of 3000.
