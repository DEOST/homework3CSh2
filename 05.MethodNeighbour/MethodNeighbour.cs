//Write a method that checks if the element at given position in given array of 
//integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MethodNeighbour
{
    class MethodNeighbour
    {
        static void Main()
        {
         /*   Console.WriteLine("Type a number of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }*/
            int[] arr = new int[] { 1, 9, 0, 6, 4, 12, 9, 3, -50, 1, 20, 14, 5 };
            Console.Write("Enter a position of element ");
            int k = int.Parse(Console.ReadLine());
            while (k <= 0 || k >= arr.Length)
            {
                Console.WriteLine("Type corect position");
                k = int.Parse(Console.ReadLine());
            }

            if (CheckNeighbour(arr, k))
            {
                Console.WriteLine("It is bigger then its Neighbour elements");
            }
            else
                Console.WriteLine("It is not bigger then its Neighbour elements");
        }
        public static bool CheckNeighbour(int[] arr, int k)
        {
            if (arr[k - 1] < arr[k] && arr[k] > arr[k + 1])
            {
                return true;
            }
            else return false;
        }
    }
}
