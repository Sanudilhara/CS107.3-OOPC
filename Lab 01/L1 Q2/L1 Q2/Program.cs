using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.WriteLine("Enter the radius of the circle= ");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14 * radius * radius;

            Console.WriteLine("the area of the circle= " + area);
            Console.ReadLine();
        }
    }
}
