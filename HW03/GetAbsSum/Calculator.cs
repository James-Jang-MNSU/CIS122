// Written by James Jang
// 02/11/2025 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAbsSum
{
    public class Calculator
    {
        // class methods
        public int GetAbsSum(int[] arrayOfNums)
        {
            int sum = 0;
            foreach (int num in arrayOfNums)
            {
                if (num < 0)
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
