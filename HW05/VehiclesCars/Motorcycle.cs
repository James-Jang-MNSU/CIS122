// Written by James Jang
// 02/23/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesCars
{
    public class Motorcycle : Vehicle
    {
        // class variables
        private bool hasSidecar = false;

        // gets and sets
        private bool HasSidecar
        {
            get { return this.hasSidecar; }
            set { this.hasSidecar = value; }
        }

        // class constructors
        public Motorcycle() : base() { }
        public Motorcycle(string aMake, string aModel, int aYear, bool aHasSidecar) : base(aMake, aModel, aYear)
        {
            HasSidecar = aHasSidecar;
        }

        // class methods
        public override string ToString()
        {
            return base.ToString() + $", Has Sidecar: {HasSidecar}";
        }
    }
}
