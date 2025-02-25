// Written by James Jang
// 02/23/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesCars
{
    public class Car : Vehicle
    {
        // class variables
        private int numberOfDoors = -1;

        // gets and sets
        public int NumberOfDoors
        {
            get { return this.numberOfDoors; }
            set { this.numberOfDoors = value; }
        }

        // class constructors
        public Car() : base() { }
        public Car(string aMake, string aModel, int aYear, int aNumberofDoors) : base(aMake, aModel, aYear)
        {
            NumberOfDoors = aNumberofDoors;
        }

        // class methods
        public override string ToString()
        {
            return base.ToString() + $", with {NumberOfDoors} doors";
        }
    }
}
