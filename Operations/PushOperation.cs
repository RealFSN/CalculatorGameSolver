using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class PushOperation : IOperation
    {
        private int constant;
        private string description;

        public PushOperation(int constant)
        {
            this.constant = constant;
            description = "Push " + constant;
        }

        public double Execute(double input)
        {
            return double.Parse(input.ToString() + constant);
        }

        public override string ToString()
        {
            return description;
        }
    }
}
