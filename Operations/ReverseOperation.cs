using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class ReverseOperation : Operation
    {
        public ReverseOperation()
        {
            Name = "Reverse";
        }

        public override double Execute(double input)
        {
            string str = input.ToString();
            bool isNegative = false;
            if (input < 0)
            {
                isNegative = true;
                str = str.Remove(0, 1);
            }
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            string newStr = isNegative ? '-' + new string(c) : new string(c);
            return double.Parse(newStr);
        }
    }
}
