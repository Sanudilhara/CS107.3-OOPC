using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area, circum;
            Console.WriteLine("Enter the radius of the circle= ");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14 * radius * radius;
            circum = 2 * 3.14 * radius;
            Console.WriteLine("the area of the circle= " + area);
            Console.WriteLine("the circumference of the circle = " + circum);
            Console.ReadLine();
        }
    }
}
