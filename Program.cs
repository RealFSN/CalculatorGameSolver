using CalculatorGameSolver.Operations;
using System.Buffers;
using System.Reflection.Metadata.Ecma335;
namespace CalculatorGameSolver;

internal class Program
{
    static void Main(string[] args)
    {
        int initialNum = 0;
        int numberOfMoves = 7;
        int goal = -43;

        List<Operation> operations = new List<Operation>()
        {
            new SubtractConstantOperation(5),
            new SubtractConstantOperation(9),
            new AddConstantOperation(7),
            new ReverseOperation()
        };

        var perms = GenerateAllPermutationsWithRepetition(operations, numberOfMoves);

        List<int> solutions = new();

        for (int i = 0; i < perms.Count; i++)
        {
            var p = perms[i];
            double val = initialNum;
            for (int j = 0; j < p.Count; j++)
            {
                val = p[j].Execute(val);
            }

            if (val == goal)
            {
                solutions.Add(i);
            }
        }

        for (int i = 0; i < solutions.Count; i++)
        {
            var perm = perms[solutions[i]];
            for (int j = 0; j < perm.Count; j++)
            {
                Console.WriteLine(perm[j].Name);
            }
            Console.WriteLine();
        }
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
