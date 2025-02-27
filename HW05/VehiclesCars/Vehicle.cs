// Written by James Jang
// 02/23/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesCars
{
    public class Vehicle
    {
        // class variables
        protected string make = "n/a";
        protected string model = "n/a";
        protected int year = -1;

        // gets and sets
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        // class constructors
        public Vehicle(string aMake, string aModel, int aYear)
        {
            this.Make = aMake;
            this.Model = aModel;
            this.Year = aYear;
        }
        public Vehicle(): this("unknown", "unknown", -1) { }
        

        // class methods 
        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}";
        }
    }
}
