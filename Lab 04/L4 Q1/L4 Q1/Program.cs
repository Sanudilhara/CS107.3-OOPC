using L4_Q1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert_Values converter = new Convert_Values();
            converter.KilometerToMeter();

            Console.ReadKey();
        }
    }
}
