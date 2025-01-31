// Written by James Jang
// 01/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTriangleFarmer
{
    public class Triangle
    {
        // class variables
        private int heightOfTriangle = -1;
        private int baseOfTriangle = -1;

        // gets and sets
        public int HeightOfTriangle
        {
            get { return this.heightOfTriangle; }
            set {
                if (value > 0)
                {
                    this.heightOfTriangle = value;
                }
            }
        }
        public int BaseOfTriangle
        {
            get { return this.baseOfTriangle; }
            set
            {
                if (value > 0)
                {
                    this.baseOfTriangle = value;
                }
            }
        }

        // constructor
        public Triangle(int aHeight, int aBase)
        {
            this.HeightOfTriangle = aHeight;
            this.baseOfTriangle = aBase;
        }
        public Triangle() : this(0, 0)
        {

        }
    
        // class methods
        public double AreaOfTriangle()
        {
            return HeightOfTriangle * BaseOfTriangle / 2.0;
        }
    }
}
