using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingNumber.Interfaces;

namespace MissingNumber.Solutions
{

    public class BruteForce : IMissingNumber
    {
        /// <summary>
        /// Finds the missing number in the input array using a brute-force map lookup approach.
        /// </summary>
        /// <param name="nums">An array of unique integers in the range [0..n] with one number missing.</param>
        /// <returns>The missing number, or -1 if not found (should not occur).</returns>
        public int FindMissingNumber(int[] nums)
        {
            int lenOfArray = nums.Length;

            Dictionary<int, bool> map = new Dictionary<int, bool>();
            foreach (int num in nums)
            {
                map.Add(num, true);
            }

            for (int i = 0; i <= lenOfArray; i++)
            {
                if (!map.ContainsKey(i)) {
                    return i;
                }
            }

            return -1;
        }
    }
}
