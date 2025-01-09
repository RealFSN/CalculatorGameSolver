using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class ReplaceOperation : IOperation
    {
        private double fromVal;
        private double toVal;

        private string description;

        public ReplaceOperation(double fromVal, double toVal)
        {
            this.fromVal = fromVal;
            this.toVal = toVal;

            description = fromVal + " => " + toVal;
        }

        public double Execute(double input)
        {
            string str = input.ToString();
            str = str.Replace(fromVal.ToString(), toVal.ToString());
            return double.Parse(str);
        }

        public override string ToString()
        {
            return description;
        }
    }
}
