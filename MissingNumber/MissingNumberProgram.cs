using missingNumber;
using MissingNumber.Interfaces;
using MissingNumber.Solutions;

namespace missingNumber
{
    class MissingNumberProgram
    {
        static void Main(string[] args) {
            // Test cases
            int[] nums1 = { 3, 0, 1 };
            int[] nums2 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            // Two alternate solutions
            IMissingNumber sumFinder = new SumFormula();
            IMissingNumber sortFinder = new SortCompare();

            // Using sum formula
            int sumNums1 = sumFinder.FindMissingNumber(nums1);
            int sumNums2 = sumFinder.FindMissingNumber(nums2);

            // Using sort and compare
            int sortNums1 = sortFinder.FindMissingNumber(nums1);
            int sortNums2 = sortFinder.FindMissingNumber(nums2);

            // Output results
            Console.WriteLine("Using Sum Solution:");
            Console.WriteLine($"Missing in nums1: {sumNums1}");
            Console.WriteLine($"Missing in nums2: {sumNums2}");

            Console.WriteLine();

            Console.WriteLine("Using Sort Solution:");
            Console.WriteLine($"Missing in nums1: {sortNums1}");
            Console.WriteLine($"Missing in nums2: {sortNums2}");
        }
    }
}