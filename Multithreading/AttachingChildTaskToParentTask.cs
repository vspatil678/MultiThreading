using System;
using System.Threading.Tasks;

namespace Multithreading
{
    class AttachingChildTaskToParentTask
    {
        static void Mains(string[] args)
        {
            Task<Int32[]> parent = Task.Run(() =>
            {

                var results = new Int32[3];
                new Task(
                    () => { results[0] = 0; }, 
                    TaskCreationOptions.AttachedToParent).Start();

                new Task(
                    () => { results[1] = 1; },
                    TaskCreationOptions.AttachedToParent).Start();

                new Task(
                    () => { results[2] = 2; },
                    TaskCreationOptions.AttachedToParent).Start();
                return results;
            });
            var finalTask = parent.ContinueWith(parentTask => {
                foreach (var item in parent.Result)
                {
                    Console.WriteLine(item);
                }
            });
            finalTask.Wait();
        }
    }
}
