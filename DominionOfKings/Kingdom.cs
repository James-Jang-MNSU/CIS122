// Written by James Jang
// 01/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionOfKings
{
    public class Kingdom
    {
        // class variables
        private int numOfProvinces = -1;
        private int numOfDuchies = -1;
        private int numOfEstates = -1;

        // gets and sets
        public int NumOfProvinces
        {
            get { return numOfProvinces; }
            set { numOfProvinces = value; }
        }
        public int NumOfDuchies
        {
            get { return numOfDuchies;  }
            set { numOfDuchies = value; }
        }
        public int NumOfEstates
        {
            get { return numOfEstates; }
            set { numOfEstates = value; }
        }

        // constructors
        public Kingdom(int aNumOfProvinces, int aNumOfDuchies, int aNumOfEstates)
        {
            this.numOfProvinces = aNumOfProvinces;
            this.numOfDuchies = aNumOfDuchies;
            this.numOfEstates = aNumOfEstates;
        }
        public Kingdom() : this(-1, -1, -1) { }

        // class methods
        public int CalcKindomPoints()
        {
            return numOfProvinces * 6 + numOfDuchies * 3 + numOfEstates;
        }
        public override string ToString()
        {
            string message = "";
            message += "Number of provinces: " + NumOfProvinces + "\n"
                + "Number of duchies: " + NumOfDuchies + "\n"
                + "Number of estates: " + NumOfEstates + "\n";
            return message;
        }
    }
}
