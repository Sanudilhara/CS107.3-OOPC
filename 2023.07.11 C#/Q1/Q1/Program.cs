using Q1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID:");
            string empID = Console.ReadLine();

            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Designation:");
            string empDesignation = Console.ReadLine();

            Encapsulation empobj = new Encapsulation();

            empobj.setempID(empID);
            empobj.setempName(empName);
            empobj.setempDesignation(empDesignation);

            Console.WriteLine("Hello " + empobj.getempName() + " your employee ID is " + empobj.getempID() + " and you are a " + empobj.getempDesignation());

            Console.ReadLine();
        }
    }
}
