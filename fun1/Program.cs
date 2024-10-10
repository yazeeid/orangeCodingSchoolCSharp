using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fun1
{
    internal class Program
    {
        static string convert(int m)
        {
            return $"{m} Minutes is {m*60} Seconds";
        }

        static string addOne(double m)
        {
            return $"total is {m + 1}";

        }

        static int fisrtElement(int[] arr)
        {
            return arr[0];

        } 

        static double area(double s1,double s2)
        {
            return 0.5 * s1 * s2;
        }

        static int[] evenNumEvenIndex(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0 && i % 2 == 0)
                {
                    count++;
                }
            }

            int[] newArray = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && i % 2 == 0)
                {
                    newArray[index] = arr[i];
                    index++;
                }
            }

            return newArray;
        }

        static int[] powerElementIndex(int[] arr)
        {
            int[] newArray = new int[arr.Length];

            for(int i = 0; i < arr.Length; i++)
            {
                newArray[i] = Convert.ToInt32(Math.Pow(arr[i], i));
            }
            return newArray;
        }


        static int multiOne(int x1,int x2)
        {
            int sum = 0;
            for(int i = 0; i < x2; i++)
            {
                sum += x1;
            }
            return sum;
        }
        static int multiTwo(int x1, int x2)
        {
            int sum = 1;
            for (int i = x1; i <= x2; i++)
            {
                sum *= i;
            }
            return sum;
        }
        public static double aveArray(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return Convert.ToDouble(sum) / arr.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Minutes");
            int s1=Int32.Parse(Console.ReadLine());
            Console.WriteLine(convert(s1));

            Console.WriteLine("Enter nubmer to add One");
            Console.WriteLine(addOne(Convert.ToDouble(Console.ReadLine())));

            int[] arr1 = { 1, 5, 6, 9 };
            Console.WriteLine($"Fisrt index is {fisrtElement(arr1)}");


            Console.WriteLine("Enter base and hight of tringle separated with comma");
            string x1 = Console.ReadLine();
            string[] val = x1.Split(',');
            double b1 = Convert.ToDouble(val[0]);
            double b2 = Convert.ToDouble(val[1]);

            Console.WriteLine($"area is {area(b1, b2)} ");


            int[] arr2 = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1};


            int[] arr3 = evenNumEvenIndex(arr2);

            Console.WriteLine("arary with evenNumEvenIndex :");

            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }


            int[] arr4 = { 44, 5, 4, 3, 2, 10 };


            int[] arr5 = powerElementIndex(arr4);

            Console.WriteLine("arary with powerElementIndex :");

            foreach (int item in arr5)
            {
                Console.WriteLine(item);
            }
                

            Console.WriteLine(multiOne(4, 5));
            Console.WriteLine(multiTwo(3, 6));

            int[] arr22= { 1, 2, 3, 8, 9 };
            Console.WriteLine(aveArray(arr22));
        }
    }
}
