// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Engineer : Employee
    {
        // class variables
        private string specialization = "n/a";

        // gets and sets
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        // constructors
        public Engineer(string aName, double aSalary, string aSpecialization) : base(aName, aSalary)
        {
            this.Specialization= aSpecialization;
        }
        public Engineer() : this("unknown", 0, "unknown") { }

        // class methods
        public override string ToString()
        {
            return base.ToString() + $", Specialization: {this.Specialization}";
        }
    }
}
