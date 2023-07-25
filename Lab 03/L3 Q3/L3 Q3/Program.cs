using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Digit Sum Calculator!");

            
            Console.Write("Enter a number: ");
            int number;
            number = int.Parse(Console.ReadLine());

            
            int digitSum = 0;
            int tempNumber = Math.Abs(number); 

            while (tempNumber != 0)
            {
                digitSum += tempNumber % 10; 
                tempNumber /= 10; 
            }

            
            Console.WriteLine("Sum of the digits of the number: "+digitSum);

            Console.ReadKey();
        }
    }
}
