//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest 
//of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetMax
{
    class Program
    {
        static void Main()
        {
            
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            GetMax(arr);
            Console.WriteLine("Max number is {0}", GetMax(arr));
        }
        public static int GetMax(int[] arr)
        {
           int maxNum = arr.Max();
		   return maxNum;

	    }

        }
    }

