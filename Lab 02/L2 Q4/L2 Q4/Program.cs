using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, even, odd;
            Console.WriteLine("Enter a number = ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
            {
                Console.WriteLine("INVALID;it is zero!!");
                Console.ReadLine();
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("Even number!!");
                Console.ReadLine();
            }
            else if (i % 2 == 1)
            {
                Console.WriteLine("Odd number!!");
                Console.ReadLine();
            }
    }
}
