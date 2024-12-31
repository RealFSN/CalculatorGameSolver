using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class MultiplyOperation : Operation
    {
        private int constant;

        public MultiplyOperation(int constant)
        {
            this.constant = constant;
            Name = "x" + constant;
        }

        public override double Execute(double input)
        {
            return input * constant;
        }
    }
}
