using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class PushConstantOperation : Operation
    {
        private int constant;

        public PushConstantOperation(int constant)
        {
            this.constant = constant;
            Name = "Push " + constant;
        }

        public override double Execute(double input)
        {
            return double.Parse(input.ToString() + constant);
        }
    }
}
