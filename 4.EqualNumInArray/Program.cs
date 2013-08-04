//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.EqualNumInArray
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Type a number of array");
            int n= int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("The Number {0} appear in array {1} times", k, CountNum(arr,k));
        }
        public static int CountNum(int[] arr, int k)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==k)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
