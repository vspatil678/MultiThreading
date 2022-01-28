using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class TaskReturnSomeValue
    {
        static void Main1(string[] args)
        {
            Task<int> t = Task.Run(() => { return 42;  });
            Console.WriteLine(t.Result);
        }
    }
}
