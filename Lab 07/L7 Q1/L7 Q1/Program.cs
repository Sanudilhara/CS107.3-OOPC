using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the size of the arrays: ");
                int size;
                while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer value.");
                    Console.Write("Enter the size of the arrays: ");
                }

                int[] array1 = new int[size];
                int[] array2 = new int[size];
                int[] vectorSumArray = new int[size];
                int[] vectorProductArray = new int[size];
                int scalarSum = 0;
                int scalarProduct = 0;

                Console.WriteLine("Enter values for the first array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    while (!int.TryParse(Console.ReadLine(), out array1[i]))
                    {
                        Console.WriteLine("Invalid input. Please enter an integer value.");
                        Console.Write($"Value {i + 1}: ");
                    }
                }

                Console.WriteLine("Enter values for the second array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Value {i + 1}: ");
                    while (!int.TryParse(Console.ReadLine(), out array2[i]))
                    {
                        Console.WriteLine("Invalid input. Please enter an integer value.");
                        Console.Write($"Value {i + 1}: ");
                    }
                }

               
                for (int i = 0; i < size; i++)
                {
                    scalarSum += array1[i] + array2[i];
                }

               
                for (int i = 0; i < size; i++)
                {
                    vectorSumArray[i] = array1[i] + array2[i];
                }

                
                for (int i = 0; i < size; i++)
                {
                    vectorProductArray[i] = array1[i] * array2[i];
                }

                
                scalarProduct = 0;
                for (int i = 0; i < size; i++)
                {
                    scalarProduct += array1[i] * array2[i];
                }

                Console.WriteLine($"Scalar Sum: {scalarSum}");
                Console.WriteLine("Vector Sum:");
                PrintArray(vectorSumArray);
                Console.WriteLine("Vector Product:");
                PrintArray(vectorProductArray);
                Console.WriteLine($"Scalar Product: {scalarProduct}");
            }

            static void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
