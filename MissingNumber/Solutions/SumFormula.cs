using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingNumber.Interfaces;

namespace MissingNumber.Solutions
{
    public class SumFormula : IMissingNumber
    {
        /// <summary>
        /// Calculates the missing number by subtracting the actual sum of the array 
        /// from the expected sum of the full range [0..n].
        /// </summary>
        /// <param name="nums">An array of unique integers in the range [0..n] with one missing value.</param>
        /// <returns>The missing number.</returns>
        public int FindMissingNumber(int[] nums)
        {
            int lenOfArray = nums.Length;
            int expectedSum = lenOfArray * (lenOfArray + 1) / 2;
            int actualSum = nums.Sum();
            return expectedSum - actualSum;
        }
    }
}
