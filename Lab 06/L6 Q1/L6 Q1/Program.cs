using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer value.");
                Console.Write("Enter the size of the array: ");
            }

            ArrayHelper arrayHelper = new ArrayHelper(size);
            arrayHelper.InputValues();
            arrayHelper.PrintArray();
        }
    }
}
