using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class TaskFactoryClass
    {
        static void Main1(string[] args)
        {
            Task<Int32[]> parent = Task.Run(
                () =>
                {
                    TaskFactory taskFactory = new TaskFactory(
                        TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);
                    Int32[] results = new Int32[3];
                    taskFactory.StartNew(() => results[1] = 1);
                    taskFactory.StartNew(() => results[2] = 2);
                    // new Task(() =>
                    //{ results[0] = 0; }, TaskCreationOptions.AttachedToParent).Start();

                    // instead of using above code we can make use of TaskFactory
                    taskFactory.StartNew(() => results[0] = 0);

                    return results;
                }

                );

            var finalTask = Task.Run(() => {
                foreach (var item in parent.Result)
                {
                    Console.WriteLine(item);
                }
            });

            finalTask.Wait();
        }
    }
}
