using CalculatorGameSolver.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGameSolver
{
    public class Solver
    {
        public List<Solution> Solve(int initialNumber, int numberOfMoves, int goal, List<IOperation> operations)
        {
            var perms = GenerateAllPermutationsWithRepetition(operations, numberOfMoves);
            var solutions = new List<Solution>();

            foreach (List<IOperation> ops in perms)
            {
                List<IOperation> solutionOps = new List<IOperation>();
                double val = initialNumber;

                foreach (IOperation op in ops)
                {
                    val = op.Execute(val);
                    solutionOps.Add(op);

                    if (val == goal)
                    {
                        var solution = new Solution(solutionOps);
                        solutions.Add(solution);

                        // create new copy of solutions
                        // to avoid changing the solutionOps after solution has been created
                        // because solutionOps is a reference type.
                        solutionOps = new List<IOperation>(solutionOps);
                    }
                }
            }

            return solutions;
        }

        private List<List<IOperation>> GenerateAllPermutationsWithRepetition(List<IOperation> ops, int n)
        {
            if (n == 0)
            {
                var ls = new List<List<IOperation>>
                {
                    new List<IOperation>()
                };
                return ls;
            }

            var list = GenerateAllPermutationsWithRepetition(ops, n - 1);

            var newList = new List<List<IOperation>>(list.Count * ops.Count);

            for (int i = 0; i < ops.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    var ls = new List<IOperation>(list[j]);
                    ls.Insert(0, ops[i]);
                    newList.Add(ls);
                }
            }

            return newList;
        }
    }
}
