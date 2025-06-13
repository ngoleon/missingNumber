using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingNumber.Interfaces;

namespace MissingNumber.Solutions
{
    public class SortCompare : IMissingNumber
    {
        /// <summary>
        /// Finds the missing number in the input array by sorting and comparing indices to values.
        /// </summary>
        /// <param name="nums">An array of unique integers in the range [0..n] with one number missing.</param>
        /// <returns>The missing number if found; otherwise, -1 (should not occur if input is valid).</returns>
        public int FindMissingNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
