using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class SubtractOperation : IOperation
    {
        private int constant;
        private string description;

        public SubtractOperation(int constant)
        {
            this.constant = constant;
            description = "-" + constant;
        }

        public double Execute(double input)
        {
            return input - constant;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
