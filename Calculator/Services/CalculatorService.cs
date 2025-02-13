using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class CalculatorService
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool isEven(int num)
        {
            return num % 2 == 0;
        }

        public bool isOdd (int num)
        {
            return num % 2 != 0;
        }
    }
}
