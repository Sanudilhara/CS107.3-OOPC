using L4_Q2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the kilometer value: ");
            double kilometer;
            kilometer = double.Parse(args[0]);

            Convert_Values converter = new Convert_Values();
            converter.KilometerToMeter(kilometer);

            Console.ReadKey();
        }
    }
}
