using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Even or Odd Checker!");

            
            Console.Write("Enter an integer: ");
            int number;
            number = int.Parse(Console.ReadLine());

            
            string result = (number % 2 == 0) ? "Even" : "Odd";

            
            Console.WriteLine($"The number {number} is {result}.");

            Console.ReadKey();
        }
    }
}
