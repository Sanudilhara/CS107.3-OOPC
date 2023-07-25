using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Q1.Properties
{
    class Convert_Values
    {
        public void KilometerToMeter()
        {
            Console.WriteLine("Welcome to the Kilometer to Meter Converter!");

            Console.Write("Enter the kilometer value: ");
            double kilometer;
            kilometer = double.Parse(Console.ReadLine());

            double meter = kilometer * 1000;

            Console.WriteLine($"{kilometer} kilometer is equal to {meter} meters.");
        }
    }
}
