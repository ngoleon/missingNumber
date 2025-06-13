using missingNumber;
using MissingNumber.Input;
using MissingNumber.Interfaces;
using MissingNumber.Solutions;

namespace missingNumber
{
    class MissingNumberProgram
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter a comma-separated array of numbers (e.g. 3,0,1):");
            string input = Console.ReadLine();

            int[] nums;

            try
            {
                nums = InputParser.Parse(input);
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter valid numbers separated by commas.");
                return;
            }

            var strategies = SolutionRegistry.All;

            Console.WriteLine("\nChoose a strategy:");
            foreach (var kv in strategies)
            {
                Console.WriteLine($"[{kv.Key}] {kv.Value.Label}");
            }

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (!strategies.TryGetValue(choice, out var selected))
            {
                Console.WriteLine("Invalid strategy selected.");
                return;
            }

            int result = selected.Solution.FindMissingNumber(nums);

            Console.WriteLine($"\nSolution: {selected.Label}");
            Console.WriteLine($"Missing number is: {result}");
        }
    }
}