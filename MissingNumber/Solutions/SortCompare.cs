using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingNumber.Interfaces;

namespace MissingNumber.Solutions
{
    // Depends on IMissingNumber interface
    public class SortCompare : IMissingNumber
    {


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
