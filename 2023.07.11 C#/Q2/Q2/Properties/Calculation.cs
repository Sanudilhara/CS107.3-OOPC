using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2.Properties
{
    public class Calculation
    {
        private double number1;
        private double number2;

        public void setValue(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public double getAddition()
        {
            return number1 + number2;
        }
        public double getSubstraction()
        {
            return number1 - number2;
        }
        public double getMultiplication()
        {
            return number1 * number2;
        }
        public double getDivision()
        {
            return number1 / number2;
        }
    }
}
