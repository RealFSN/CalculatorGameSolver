using CalculatorGameSolver.Operations;
using System.Buffers;
using System.Reflection.Metadata.Ecma335;
namespace CalculatorGameSolver;

internal class Program
{
    static void Main(string[] args)
    {
        int initialNum = 44;
        int numberOfMoves = 5;
        int goal = 52;

        List<Operation> operations = new List<Operation>()
        {
            new AddOperation(9),
            new MultiplyOperation(4),
            new MultiplyOperation(-1),
            new DivideOperation(2),
        };

        var perms = GenerateAllPermutationsWithRepetition(operations, numberOfMoves);

        List<int> solutions = new();
        List<int> stepsToGetSolution = new();

        for (int i = 0; i < perms.Count; i++)
        {
            var p = perms[i];
            double val = initialNum;
            for (int j = 0; j < p.Count; j++)
            {
                val = p[j].Execute(val);

                if (val == goal)
                {
                    solutions.Add(i);
                    stepsToGetSolution.Add(j);
                }
            }
        }

        for (int i = 0; i < solutions.Count; i++)
        {
            var perm = perms[solutions[i]];
            Console.WriteLine("Number of steps taken: " + (stepsToGetSolution[i] + 1));
            for (int j = 0; j <= stepsToGetSolution[i]; j++)
            {
                Console.WriteLine(perm[j].Name);
            }
            Console.WriteLine();
        }

        Console.WriteLine("The Minimum Number of Steps to Get The Answer is: " + (stepsToGetSolution.Min() + 1));
    }

    static List<List<Operation>> GenerateAllPermutationsWithRepetition(List<Operation> ops, int n)
    {
        if (n == 0)
        {
            var ls = new List<List<Operation>>
            {
                new List<Operation>()
            };
            return ls;
        }

        var list = GenerateAllPermutationsWithRepetition(ops, n - 1);

        var newList = new List<List<Operation>>(list.Count * ops.Count);

        for (int i = 0; i < ops.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                var ls = new List<Operation>(list[j]);
                ls.Insert(0, ops[i]);
                newList.Add(ls);
            }
        }

        return newList;
    }
}
