using CalculatorGameSolver.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver
{
    public struct Solution
    {
        public Solution(List<IOperation> operations)
        {
            this.operations = operations;
        }

        public List<IOperation> operations;
    }
}
