using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Calculator!");

            
            Console.Write("Enter the first number: ");
            double num1;
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2;
            num2 = double.Parse(Console.ReadLine());

            
            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            double division = sum / 2;

            
            Console.WriteLine("Sum: " +sum);
            Console.WriteLine("Subtraction: " +difference);
            Console.WriteLine("Multiplication: " +product);
            Console.WriteLine("Division: " + division);

            
            Console.ReadKey();
        }
    }
}
