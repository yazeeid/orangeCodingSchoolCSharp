using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathName = @"C:\Users\yazee\C#\yazeed.txt";

            if (File.Exists(pathName))
            {
                string[] arr = File.ReadAllLines(pathName);
                
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
                int count1 = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    for(int j = 0; j < arr[i].Length; j++)
                    {
                        if(arr[i][j] ==' ')
                        {
                            continue;
                        }
                        count1++;
                    }
                }
                int count2 = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                   
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (j==0)
                        {
                            count2++;
                        }
                        if (arr[i][j] == ' ')
                        {
                            count2++;
                        }
                        
                    }
                }
                Console.WriteLine("total number of characters without spaces is = " + count1);

                Console.WriteLine("total number of words without spaces is = " + count2);
            }
            else
            {
                Console.WriteLine("File not found.");
            }


        }
    }
}
