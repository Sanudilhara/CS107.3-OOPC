using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Q2.Properties
{
    internal class Convert_Values
    {
        public void KilometerToMeter(double kilometer)
        {
            Console.WriteLine("Welcome to the Kilometer to Meter Converter!");

            double meter = kilometer * 1000;
            
            Console.WriteLine($"{kilometer} kilometer is equal to {meter} meters.");
        }
    }
}
