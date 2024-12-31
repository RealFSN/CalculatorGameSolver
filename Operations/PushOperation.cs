using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class PushOperation : Operation
    {
        private int constant;

        public PushOperation(int constant)
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
