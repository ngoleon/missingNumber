using missingNumber;
using MissingNumber.Input;
using MissingNumber.Interfaces;
using MissingNumber.Solutions;

namespace missingNumber
{
    class MissingNumberProgram
    {
        static void Main(string[] args) {
            var nums = ConsoleUI.UserStringPrompt();
            if (nums == null)
            {
                return;
            }

            var solution = ConsoleUI.UserSolutionPrompt();
            if (solution == null) 
            {
                return;
            }

            int result = solution.FindMissingNumber(nums);
            Console.WriteLine($"\nMissing number is: {result}");
        }
    }
}