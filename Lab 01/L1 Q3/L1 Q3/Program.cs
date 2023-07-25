using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.WriteLine("Enter input1= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter input2= ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("sum of the two inputs= " + sum);
            Console.ReadLine();
        }
    }
}
