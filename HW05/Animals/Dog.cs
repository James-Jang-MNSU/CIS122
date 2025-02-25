// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        // constructors
        public Dog(string aName) : base(aName) { }
        public Dog(): base() { }

        // class methods
        public override string MakeSound()
        {
            return "Bark";
        }
    }
}
