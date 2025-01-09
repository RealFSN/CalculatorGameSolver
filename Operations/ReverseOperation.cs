using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class ReverseOperation : IOperation
    {
        private string description;

        public ReverseOperation()
        {
            description = "Reverse";
        }

        public double Execute(double input)
        {
            double inputAbsVal = Math.Abs(input);
            if (inputAbsVal < 10)
            {
                return input;
            }

            bool isNegative = input < 0 ? true : false;
            string str = inputAbsVal.ToString();
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            string newStr = new string(c);
            double val = double.Parse(newStr);
            return isNegative ? -val : val;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
