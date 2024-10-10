using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fun2
{
    internal class Program
    {
        static int GetDays(string date1, string date2)
        {
            
            DateTime d1 = DateTime.Parse(date1);
            DateTime d2 = DateTime.Parse(date2);

            
            TimeSpan difference = d2 - d1;

            
            return Math.Abs(difference.Days);
        }

        static string[] numInStr(string[] arr)
        {
            int count = 0;
            foreach(string str in arr)
            {
                if (str.Any(char.IsDigit))
                {
                    count++;
                }
            }
            string[] arr2 = new string[count];
            int index = 0;
            foreach(string str in arr)
            {
                if (str.Any(char.IsDigit))
                {
                    arr2[index] = str;
                    index++;    
                }
            }
            return arr2;
        }


        static string ReverseOdd(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] wordArray = words[i].ToCharArray();
                    Array.Reverse(wordArray);
                    words[i] = new string(wordArray);
                }
            }
            return string.Join(" ", words);
        }
        public static bool IsPandigital(long number)
        {
            string numStr = number.ToString();

            bool[] seenDigits = new bool[10];

            foreach (char digit in numStr)
            {
                if (Char.IsDigit(digit))
                {
                    int digitValue = digit - '0';
                    seenDigits[digitValue] = true;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (!seenDigits[i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetDays("June 14, 2019", "June 20, 2019")); 
            Console.WriteLine(GetDays("December 1, 2018", "January 1, 2019"));

            string[] arr1 = { "1a", "a", "2b", "b" };

            string[] arr2 = numInStr(arr1);

            foreach (string str in arr2)
            {
                Console.WriteLine(str);
            }


            Console.WriteLine(ReverseOdd("Bananas"));               
            Console.WriteLine(ReverseOdd("One two three four"));

            Console.WriteLine(IsPandigital(98140723568910)); 
            Console.WriteLine(IsPandigital(90864523148909)); 
            Console.WriteLine(IsPandigital(112233445566778899)); 
        }
    }
}
