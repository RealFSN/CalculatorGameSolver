using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public abstract class Operation
    {
        public string Name;
        public abstract double Execute(double input);
    }
}
