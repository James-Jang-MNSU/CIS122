// Written by James Jang
// 02/11/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNum
{
    public class Calculator
    {
        // class methods
        public string SmallerNum(string num1, string num2)
        {
            return (Convert.ToInt32(num1) < Convert.ToInt32(num2)) ? num1 : num2;
        }
    }
}
