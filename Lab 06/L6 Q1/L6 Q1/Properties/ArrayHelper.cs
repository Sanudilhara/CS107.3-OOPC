using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInputWithZeros
    {
        class ArrayHelper
        {
            private int[] array;

            public ArrayHelper(int size)
            {
                array = new int[size * 2]; 
            }

            public void InputValues()
            {
                Console.WriteLine($"Enter {array.Length / 2} integer values, each followed by a value 0:");
                for (int i = 0; i < array.Length; i += 2)
                {
                    int input;
                    while (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.WriteLine("Invalid input. Please enter an integer value.");
                    }
                    array[i] = input;
                    array[i + 1] = 0;
                }
            }

            public void PrintArray()
            {
                Console.WriteLine("Values inside the array:");
                foreach (int num in array)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
