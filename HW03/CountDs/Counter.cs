// Written by James Jang
// 02/10/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDs
{
    public class Counter
    {
        // class methods
        public int CountDs(string aString)
        {
            int count = 0;
            foreach (char letter in aString)
            {
                if (letter == 'D' || letter == 'd') count++;
            }
            return count;
        }
    }
}
