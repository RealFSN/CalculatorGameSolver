using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class MultiplyByConstantOperation : Operation
    {
        private int constant;

        public MultiplyByConstantOperation(int constant)
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
