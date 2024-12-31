using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class SquareOperation : Operation
    {
        public SquareOperation()
        {
            base.Name = "x^2";
        }

        public override double Execute(double input)
        {
            return input * input;
        }
    }
}
