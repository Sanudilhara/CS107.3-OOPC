using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Salary Calculator!");

            
            Console.Write("Enter the employee's salary: ");
            double salary;
            salary = double.Parse(Console.ReadLine());

            
            Console.Write("Enter the tax rate: ");
            double taxRate;
            taxRate = double.Parse(Console.ReadLine());

            
            double taxAmount = salary * (taxRate / 100);
            double netSalary = salary - taxAmount;

            
            Console.WriteLine("Gross Salary: " +salary);
            Console.WriteLine($"Tax Rate: " +taxRate);
            Console.WriteLine($"Tax Amount: " +taxAmount);
            Console.WriteLine($"Net Salary: " +netSalary);

            Console.ReadKey();
        }
    }
}
