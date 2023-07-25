using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            double Batch;

            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter your batch: ");
            Batch = double.Parse(Console.ReadLine());

            Console.WriteLine("Your name is " + Name + " and your batch is " + Batch);
            Console.ReadLine();
        }
    }
    }
}
