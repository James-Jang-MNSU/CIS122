// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        // class variables
        private double width = -1;
        private double height = -1;

        // gets and sets
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // constructors
        public Rectangle(string aColor, double aWidth, double aHeight): base(aColor)
        {
            this.Width = aWidth;
            this.Height = aHeight;
        }
        public Rectangle(): this("unknown", -1, -1) { }

        // class methods
        public override double GetArea()
        {
            return this.Width * this.Height;
        }
        public override string ToString()
        {
            return base.ToString() + $", Width: {this.Width}, Height: {this.Height}, Area: {this.GetArea()}";
        }
    }
}