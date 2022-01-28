using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
   public static class ThreadStaticAttributeClass
    {
        [ThreadStatic] 
        public  static int _field;
        public static void Mainq(string[] args)
        {
            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread  a is running{0}", _field);
                }
            }).Start();


            new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread  b is running{0}", _field);
                }
            }).Start();
            Console.WriteLine("total count{0}", _field);
            Console.ReadLine();
        }

        //[ThreadStatic]
        //public static int _field;

        //the difference here is if we remove [ThreadStaic] attribute from variable the field count will be 1,2
        //    3,...10, 11,12..20
        //    if attribute is exist means count wil be 1 to 10 and 1 to 10
    }
}
