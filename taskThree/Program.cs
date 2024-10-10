using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Input the 10 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number-{0}: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            (int sum, double average) = CalculateSumAndAverage(numbers);

            Console.WriteLine("\nThe sum of 10 numbers is: " + sum);
            Console.WriteLine("The average is: " + average);

      
            Console.Write("Enter number to cube it");
            int n = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine(cubb(n));

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int[] filteredYears = GetYears(years);

            Console.WriteLine("Years greater than 1950: " + string.Join(", ", filteredYears));



            Console.Write("Enter age in years: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int ageInDays = AgeInDays(age);
            Console.WriteLine("Age in days: " + ageInDays);


            int totalLegs = CountAnimalLegs(2, 3, 5);
            Console.WriteLine("Total legs: " + totalLegs);



            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool isLoggedIn = Login(username, password);
            Console.WriteLine(isLoggedIn ? "Login successful" : "Login failed");

            Console.Write("Enter base number: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            int result = Power(baseNum, exponent);
            Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}");


            Console.Write("Enter a year (1900-2024): ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool isLeap = IsLeapYear(year);
            Console.WriteLine(isLeap ? $"{year} is a leap year" : $"{year} is not a leap year");




            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = IsPrime(num);
            Console.WriteLine(isPrime ? $"{num} is a prime number" : $"{num} is not a prime number");

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int wordCount = CountWords(sentence);
            Console.WriteLine("Number of words: " + wordCount);

        }
        static int CountWords(string sentence)
        {
            int count = 0;
            bool isWord = false;

            foreach (char c in sentence)
            {
                if (char.IsWhiteSpace(c))
                {
                    isWord = false;
                }
                else if (!isWord)
                {
                    isWord = true;
                    count++;
                }
            }

            return count;
        }
        static bool IsPrime(int num)
        {
            if (num % 2 == 1) return false;
            return true;
        }

        static bool IsLeapYear(int year)
        {
            return year >= 1900 && year <= 2024 && (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }
        static int Power(int baseNum, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        static bool Login(string username, string password)
        {
            string[] validUsers = { "yazeed", "ahmad", "rahma" };
            string validPassword = "password123";

            return Array.Exists(validUsers, user => user == username) && password == validPassword;
        }

        static int CountAnimalLegs(int chickens, int cows, int pigs)
        {
            return chickens * 2 + cows * 4 + pigs * 4;
        }
        static int AgeInDays(int years)
        {
            return years * 365;
        }

        static (int, double) CalculateSumAndAverage(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            double average = sum / (double)numbers.Length;
            return (sum, average);
        }

        static int cubb(int n)
        {
            return n * n * n;
        }

        static int[] GetYears(int[] years)
        {
            return years.Where(y => y > 1950).ToArray();
        }

    }
}
