using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vowel Counter!");

            
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            
            string lowerInput = input.ToLower();

            
            int vowelCount = 0;

            
            string vowels = "aeiou";

            
            foreach (char character in lowerInput)
            {
                
                if (vowels.Contains(character))
                {
                    vowelCount++;
                }
            }

            
            Console.WriteLine("Number of vowels in the string: "+vowelCount);
            Console.ReadKey();
        }
    }
}
