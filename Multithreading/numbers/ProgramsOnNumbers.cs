using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading.numbers
{
    class ProgramsOnNumbers
    {
        static void Mains(string[] args)
        {
            Int32[] numbers = new int[] { 4, 6, 5,1, 3, 2, 8};
            Int32[] sortedNumbers = SortTheGivenArray(numbers);
            // FibonicSeriesForTheGivenNumber(15);
            // bool output = CheckGivenNumberIsPrimeorNot(57);
            // bool output = CheckGivenNumberIsPalindrome(5751);
            // int output = FactorialOfAGivenNumber(6);
            // bool output = CheckArmStrongOrNot(342);
            //  int output = PrintSomeOfDigit(626);
            // SwapTwoNumbersWithoutThirdVariable(5, 10);
            // int output = ReverseGivenNumber(342);
            // FibonicTraiangle(15);
            int output = FindTheMissingNumber(numbers);
             Console.WriteLine(output);
        }

        private static Int32[] SortTheGivenArray(Int32[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }

        private static int FindTheMissingNumber(Int32[] numbers)
        {
            Int32[] sortedNumbers = SortTheGivenArray(numbers);
            int missingNumber = 0;
            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                if( i < sortedNumbers.Length - 1 && (sortedNumbers[i + 1] - sortedNumbers[i]) != 1)
                {
                    missingNumber = sortedNumbers[i] + 1;
                }
            }
            return missingNumber;
        }

        private static void FibonicTraiangle(int v)
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < v; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }

        private static void SwapTwoNumbersWithoutThirdVariable(int v1, int v2)
        {
            v1 = v1 + v2;
            v2 = v1 - v2;
            v1 = v1 - v2;

            Console.WriteLine("{0} {1}",v1, v2);

        }

        private static int ReverseGivenNumber(int v)
        {
            string number = v.ToString();
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = number.Length -1; i>= 0; i--)
            {
                stringBuilder.Append(number[i]);
            }
            return Convert.ToInt32(stringBuilder.ToString());
        }

        private static int PrintSomeOfDigit(int v)
        {
            string number = v.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + Convert.ToInt32(number[i].ToString());
            }

            return sum;
        }

        private static bool CheckArmStrongOrNot(int v)
        {
            string number = v.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + (Convert.ToInt32(number[i].ToString()) * Convert.ToInt32(number[i].ToString()) * Convert.ToInt32(number[i].ToString()));
            }

            return sum == v;
        }

        private static int FactorialOfAGivenNumber(int v)
        {
            int output = v;
            for (int i = v; i > 0; i--)
            {
                if(i != 1)
                {
                    output = output * (i - 1);
                }
                
            }
            return output;
        }

        private static bool CheckGivenNumberIsPalindrome(int v)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = v.ToString().Length -1; i >=0; i--)
            {
                stringBuilder.Append(v.ToString()[i]);
            }
            return v == Convert.ToInt32(stringBuilder.ToString());
        }

        private static bool CheckGivenNumberIsPrimeorNot(int v)
        {
            for (int i = 2; i < v; i++)
            {
                if(v%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void FibonicSeriesForTheGivenNumber(int v)
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < v; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

            
        }
    }
}
