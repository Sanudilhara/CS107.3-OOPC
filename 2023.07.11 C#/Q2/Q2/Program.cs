using Q2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number:");
            double num2 = double.Parse(Console.ReadLine());

            Calculation calobj = new Calculation();
            calobj.setValue(num1, num2);

            Console.WriteLine("Addition : " + calobj.getAddition());
            Console.WriteLine("Substraction : " + calobj.getSubstraction());
            Console.WriteLine("Multiplication : " + calobj.getMultiplication());
            Console.WriteLine("Division : " + calobj.getDivision());

            Console.ReadLine();
        }
    }
}
