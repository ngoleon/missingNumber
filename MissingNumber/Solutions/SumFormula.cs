using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingNumber.Interfaces;

namespace MissingNumber.Solutions
{
    // Depends on IMissingNumber interface
    public class SumFormula : IMissingNumber
    {
        public int FindMissingNumber(int[] nums)
        {
            int lenOfArray = nums.Length;
            int expectedSum = lenOfArray * (lenOfArray + 1) / 2;
            int actualSum = nums.Sum();
            return expectedSum - actualSum;
        }
    }
}
