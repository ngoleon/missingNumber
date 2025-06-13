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
    // Depends on IMissingNumber interface
    public class BruteForce : IMissingNumber
    {
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
