using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Odd Number Sum Calculator!");

            
            Console.Write("Enter a positive integer: ");
            int number;
            number = int.Parse(Console.ReadLine());

            int sumOfOddNumbers = 0;
            for (int i = 1; i <= number; i += 2)
            {
                sumOfOddNumbers += i;
            }

            Console.WriteLine($"Sum of odd numbers from 1 to {number}: {sumOfOddNumbers}");

            Console.ReadKey();
        }
    }
}
