﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingNumber.Interfaces;
using MissingNumber.Solutions;

namespace MissingNumber.Input
{
    internal class SolutionRegistry
    {
        /// <summary>
        /// A registry of all available missing number solving strategies, 
        /// keyed by user-selectable option IDs.
        /// </summary>
        public static Dictionary<string, (string Label, IMissingNumber Solution)> All => new()
        {
            { "1", ("BruteForce", new BruteForce()) },
            { "2", ("SumFormula", new SumFormula()) },
            { "3", ("SortCompare", new SortCompare()) }
        };
    }
}
