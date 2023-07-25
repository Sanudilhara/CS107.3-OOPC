using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sum Calculator!");

            
            Console.Write("Enter the first number: ");
            double num1;
            num1 = double.Parse(Console.ReadLine());

            
            Console.Write("Enter the second number: ");
            double num2;
            num2 = double.Parse(Console.ReadLine());

            
            double sum = num1 + num2;

            
            Console.WriteLine("The sum of {num1} and {num2} is: " +sum);
            Console.ReadKey();
        }
    }
}
