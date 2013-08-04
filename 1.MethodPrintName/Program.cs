//Write a method that asks the user for 
//his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MethodPrintName
{
    class Program
    {
        
        static void Main()
        {
            StringBuilder name = new StringBuilder();
            PrintName(name.Append(AskName()));
        }
        public static string AskName()
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        public static bool CheckName(StringBuilder name)
        {
            bool check = true;
            for (int i = 0; i < name.Length; i++)
            {
                check = (Char.IsLetter(name[i]));
                if (check == false)
                    break;
            }
            return check;
        }

        static void PrintName(StringBuilder name)
        {

            if (CheckName(name))
            {
                Console.WriteLine("Hello, {0}!", name.ToString());
            }
            else
            {
                Console.WriteLine("Incorect name !");
                Main();
            }

        }
        
    }
}
