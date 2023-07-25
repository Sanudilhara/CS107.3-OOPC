using L4_Q3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the kilometer value: ");
                double kilometer;
                kilometer = double.Parse(Console.ReadLine());

                Convert_Values converter = new Convert_Values();
                double meterValue = converter.KilometerToMeter(kilometer);

                Console.WriteLine($"{kilometer} kilometer is equal to {meterValue} meters.");

                Console.ReadKey();
            
        }
    }
}
