// Written by James Jang
// 02/11/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinMax
{
    public class Calculator
    {
        // class methods
        public (int, int) FindMinMax(int[] anArrayNums)
        {
            int min = anArrayNums[0], max = anArrayNums[0];
            foreach (int number in anArrayNums)
            {
                if (number < min) min = number;
                if (number > max) max = number;
            }
            return (min, max);
        }
    }
}
