// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        // constructors
        public Cat(string aName) : base(aName) { }
        public Cat() : base() { }

        // class methods
        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
