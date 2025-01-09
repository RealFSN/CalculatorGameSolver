using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class MultiplyOperation : IOperation
    {
        private int constant;
        private string description;

        public MultiplyOperation(int constant)
        {
            this.constant = constant;
            description = "x" + constant;
        }

        public double Execute(double input)
        {
            return input * constant;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
