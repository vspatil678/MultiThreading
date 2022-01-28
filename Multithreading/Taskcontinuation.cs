using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class Taskcontinuation
    {
        static void Main1(string[] args)
        {
            //  example 1
            Task<int> t = Task.Run(
                () => { return 42; }
                ).ContinueWith((i) => {return i.Result * 2; });

            Console.WriteLine(t.Result);

            Task<int> t1 = Task.Run(()=> { return 44; });
            t1.ContinueWith((i) => {
                Console.WriteLine("canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t1.ContinueWith((i) => {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t1.ContinueWith((i) => { 
                Console.WriteLine("completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
            completedTask.Wait();
            Console.WriteLine(t1.Result);
        }
    }
}
