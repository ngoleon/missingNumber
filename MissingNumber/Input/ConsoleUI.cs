using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingNumber.Interfaces;

namespace MissingNumber.Input
{
    internal class ConsoleUI
    {
        /// <summary>
        /// Prompts the user for a comma-separated number array and parses it.
        /// Returns null if input is invalid.
        /// </summary>
        public static int[] UserStringPrompt()
        {
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
                return null;
            }

            return nums;
        }

        /// <summary>
        /// Displays available solution and lets the user select one.
        /// Returns the selected IMissingNumber implementation, or null if invalid.
        /// </summary>
        public static IMissingNumber UserSolutionPrompt() 
        {
            var solutions = SolutionRegistry.All;

            Console.WriteLine("\nChoose a solution:");
            foreach (var kv in solutions)
            {
                Console.WriteLine($"[{kv.Key}] {kv.Value.Label}");
            }

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (!solutions.TryGetValue(choice, out var selected))
            {
                Console.WriteLine("Invalid solution selected.");
                return null;
            }

            return selected.Solution;
        }
    }
}
