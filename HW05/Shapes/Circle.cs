// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        // class variables
        private double radius = -1;

        // gets and sets
        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        // constructors
        public Circle(string aColor, double aRadius) : base(aColor)
        {
            this.Radius = aRadius;
        }
        public Circle() : this("unknown", -1) { }

        // class methods
        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
        public override string ToString()
        {
            return base.ToString() + $", Radius: {this.Radius}, Area: {this.GetArea()}";
        }
    }
}