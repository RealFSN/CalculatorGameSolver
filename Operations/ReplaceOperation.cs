using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public class ReplaceOperation : Operation
    {
        private double fromVal;
        private double toVal;

        public ReplaceOperation(double fromVal, double toVal)
        {
            this.fromVal = fromVal;
            this.toVal = toVal;

            base.Name = fromVal + " => " + toVal;
        }

        public override double Execute(double input)
        {
            string str = input.ToString();
            str = str.Replace(fromVal.ToString(), toVal.ToString());
            return double.Parse(str);
        }
    }
}
