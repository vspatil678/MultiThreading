using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading
{
    class TaskWaitAny
    {
        static void Main1(string[] args)
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() => {
                Thread.Sleep(2000);
                Console.WriteLine("Task 0");
                return 1;
            });

            tasks[1] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Task 1");
                return 1;
            });

            tasks[2] = Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Task 2");
                return 1;
            });

            Task.WaitAny(tasks);
        }
    }
}

// you no need to wait until all tasks needs to be completed 
// any of the tasks got completed means process will complete the tasks.

