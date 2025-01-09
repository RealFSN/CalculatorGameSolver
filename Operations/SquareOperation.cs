using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class SquareOperation : IOperation
    {
        private string description;

        public SquareOperation()
        {
            description = "x^2";
        }

        public double Execute(double input)
        {
            return input * input;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
