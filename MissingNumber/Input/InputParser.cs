using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber.Input
{
    public static class InputParser
    {
        /// <summary>
        /// Parses user input of comma separated values
        /// Returns a int[] of all values, or null if invalid.
        /// </summary>
        public static int[] Parse(string input)
        {
            return input.Split(',')
                        .Select(s => int.Parse(s.Trim()))
                        .ToArray();
        }
    }
}
