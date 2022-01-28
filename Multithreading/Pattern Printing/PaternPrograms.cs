using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading.Pattern_Printing
{
    public static class PaternPrograms
    {
        public static void Mains(string[] args)
        {
            // print 
            //*
            //* *
            //* * *
            //* * * *
            //* * * * *

            PrintStarsTraingle1(5);

        }

        private static void PrintStarsTraingle1(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                   Console.WriteLine("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
