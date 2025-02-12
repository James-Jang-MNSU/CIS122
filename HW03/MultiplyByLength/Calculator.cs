// Written by James Jang
// 02/10/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyByLength
{
    public class Calculator
    {
        // class methods
        public int[] MultiplyByLength(int[] anArrayOfNums)
        {
            int[] result = new int[anArrayOfNums.Length];
            for (int i = 0; i < anArrayOfNums.Length; i++)
            {
                result[i] = anArrayOfNums[i] * anArrayOfNums.Length;
            }
            return result;
        }
    }
}
