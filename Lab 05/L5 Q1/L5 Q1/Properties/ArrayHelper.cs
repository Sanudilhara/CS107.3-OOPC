using ArrayOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ArrayHelper arrayHelper = new ArrayHelper(10);
        arrayHelper.InputValues();

        int minValue = arrayHelper.GetMinimumValue();
        int maxValue = arrayHelper.GetMaximumValue();
        double averageValue = arrayHelper.GetAverageValue();

        Console.WriteLine($"Minimum value: {minValue}");
        Console.WriteLine($"Maximum value: {maxValue}");
        Console.WriteLine($"Average value: {averageValue:F2}");

        arrayHelper.ReverseOrder();
        Console.WriteLine("Reversed order of values:");
        foreach (int num in ArrayHelper)
        {
            Console.Write($"{num} ");
        }
    }
}
