using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver.Operations
{
    public interface IOperation
    {
        public abstract double Execute(double input);
    }
}
