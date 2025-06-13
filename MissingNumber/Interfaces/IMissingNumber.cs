using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingNumber.Input;

namespace MissingNumber.Interfaces
{
    /// <summary>
    /// Defines a solution for finding the missing number in an array.
    /// </summary>
    public interface IMissingNumber
    {
        int FindMissingNumber(int[] nums);
    }
}
