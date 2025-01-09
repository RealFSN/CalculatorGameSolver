using CalculatorGameSolver.Operations;
using System.Buffers;
using System.Reflection.Metadata.Ecma335;
namespace CalculatorGameSolver;

internal class Program
{
    static void Main(string[] args)
    {
        List<IOperation> operations = new List<IOperation>()
        {
            new MultiplyOperation(2),
            new AddOperation(10),
            new MultiplyOperation(-2),
            new RemoveLastDigitOperation(),
            new ReverseOperation()
        };

        var solver = new Solver();
        var solutions = new List<Solution>();

        int threshold = 10;
        for (int i = 0; i < threshold; i++)
        {
            solutions = solver.Solve(111, i, 420, operations);

            if (solutions.Count > 0)
            {
                break;
            }
        }

        if (solutions.Count == 0)
        {
            Console.WriteLine("We did not find any solutions of size 10 or less");
            return;
        }

        int min = solutions[0].operations.Count;
        foreach (var sol in solutions)
        {
            if (sol.operations.Count < min)
            {
                min = sol.operations.Count;
            }

            foreach (var op in sol.operations)
            {
                Console.WriteLine(op.ToString());
            }

            Console.WriteLine();
        }

        Console.WriteLine("The Minimum Number of Operations to Get The Answer is: " + min);
    }
}
