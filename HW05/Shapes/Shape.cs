// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        // class variables
        protected string color = "n/a";

        // gets and sets
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        // constructors
        public Shape(string aColor)
        {
            this.Color = aColor;
        }
        public Shape(): this("unkown") { }

        // class methods
        public abstract double GetArea();
        public override string ToString()
        {
            return $"{this.Color} {this.GetType().Name}";
        }
    }
}
