using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class RemoveLastDigitOperation : IOperation
    {
        private string description;

        public RemoveLastDigitOperation()
        {
            // this is how it looks in the game
            description = "<<";
        }

        public double Execute(double input)
        {
            if (Math.Abs(input) < 100)
            {
                return 0;
            }

            string str = input.ToString();
            char[] c = str.ToCharArray();
            char[] newC = new char[c.Length - 1];

            for (int i = 0; i < newC.Length; i++)
            {
                newC[i] = c[i];
            }

            string newStr = new string(newC);
            return double.Parse(newStr);
        }

        public override string ToString()
        {
            return description;
        }
    }
}
