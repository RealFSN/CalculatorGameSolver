using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class SubtractConstantOperation : Operation
    {
        private int constant;

        public SubtractConstantOperation(int constant)
        {
            this.constant = constant;
            Name = "-" + constant;
        }

        public override double Execute(double input)
        {
            return input - constant;
        }
    }
}
