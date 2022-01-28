using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PermutationsOfGivenString

namespace Multithreading.strings
{
    public class ProgramsOnStrings
    {
        public static void Mainq()
        {
            Console.WriteLine("Programs on Strings");
            // string output = ReverseString("vinod");
            // int output = StringCount("vinod");
            // bool output = CompareTwoString("vinod", "vinod");
            // bool output = DuplicateCharactersInString("vinodv");
            // string output = SortGivenString("vinoda");
            // bool output = GivenStringsAreAnagramORNot("LISTEN", "SILENc");
            // string output = PermutationsOfGivenString("vinoda");
            // bool output = GivenStringIsNumber("123");
            // int output = CountOvelsAndConsonants("vinoda");
            // int output = CountOccarnceOfCharacter("vianoda", 'a');
            // char output = PrintFirstNonRepeatedCharacterFromaString("vinoda"); // swiss java w j
            // char output = PrintFirstRepeatedCharacterInAString("vinoda");
            // string output = ReveseTheWordsInString("C# is the best");
            //  bool output = CheckGivenStringIsPalindromeOrNot("121");
            // string output = RemoveSpcificCharacterFromTheString("programing", 'g');
            int output = CountNumberOfWordsinString("C# is a good");

            Console.WriteLine(output);
            Console.ReadLine();
        }

        private static int CountNumberOfWordsinString(string v)
        {
            string[] words = v.Split(' ');
            return words.Length;
        }

        private static string RemoveSpcificCharacterFromTheString(string v1, char v2)
        {
            for (int i = 0; i < v1.Length; i++)
            {
                if(v1[i] == v2)
                {
                  v1 =  v1.Remove(i, 1);
                }
            }
            return v1;
        }

        private static bool CheckGivenStringIsPalindromeOrNot(string v)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = v.Length-1; i >= 0; i--)
            {
                stringBuilder.Append(v[i]);
            }
            return stringBuilder.ToString() == v;
        }

        private static string ReveseTheWordsInString(string v)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] words = v.Split(' ');
            for (int i = words.Length -1; i>=0; i--)
            {
                stringBuilder.Append(words[i] + " ");
            }
            return stringBuilder.ToString();

        }

        private static char PrintFirstRepeatedCharacterInAString(string v1)
        {
            char characterToSearch;
            for (int i = 0; i < v1.Length; i++)
            {
                characterToSearch = v1[i];
                for (int j = i + 1; j < v1.Length; j++)
                {
                    if (characterToSearch == v1[j])
                    {
                        return characterToSearch;
                    }
                }
            }
            return '\0';
        }

        private static char PrintFirstNonRepeatedCharacterFromaString(string v1)
        {
            char characterToSearch;
            int lastLoopCount = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                characterToSearch = v1[i];
                for (int j = i+1; j < v1.Length; j++)
                {
                    if(characterToSearch == v1[j])
                    {
                        break;
                    }
                    lastLoopCount = j;
                }
                if(lastLoopCount == v1.Length-1)
                {
                    return characterToSearch;
                }
            }
            return '\0';
        }

        private static int CountOccarnceOfCharacter(string v1, char v2)
        {
            int count = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                if(v1[i] == v2)
                {
                    count++;
                }
            }
            return count;
        }

        private static int CountOvelsAndConsonants(string v)
        {
            int count = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if(v[i] == 'a' || v[i] == 'e' || v[i] == 'i' || v[i] == 'o' || v[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }

        private static bool GivenStringIsNumber(string v)
        {
            return int.TryParse(v, out _);
        }

        private static string PermutationsOfGivenString(string v)
        {
            return null;
        }

        private static string SortGivenString(string givenString)
        {
            StringBuilder v = new StringBuilder(givenString);
            for (int i = 0; i < v.Length; i++)
            {
                for (int j= i+1; j < v.Length; j++)
                {
                    if(v[i] > v[j])
                    {
                        char temp = v[i];
                        v[i] = v[j];
                        v[j] = temp;
                    }
                }
            }
            return v.ToString();
        }

        private static bool GivenStringsAreAnagramORNot(string v1, string v2)
        {
            string sortedString1 = SortGivenString(v1);
            string sortedString2 = SortGivenString(v2);

            if(sortedString1.Length != sortedString2.Length || sortedString1 != sortedString2)
            {
                return false;
            }
            return true;
        }

        private static bool DuplicateCharactersInString(string v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i+1; j < v.Length; j++)
                {
                    if(v[i] == v[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool CompareTwoString(string v, string v1)
        {
            bool isSame = true;
            if (v.Length != v1.Length)
            {
                return false;
            }
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i; j < v1.Length;)
                {
                    if (v[i] != v1[j])
                    {
                        return false;
                    }
                    break;
                }
            }
            return isSame;
        }

        private static int StringCount(string v)
        {
            int count = 0;

            for (int i = 0; i < v.Length; i++)
            {
                count++;
            }
            return count;
        }

        public static string ReverseString(string input)
        {
            string data = null;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                data += input[i];
            }
            return data;
        }
    }
}
