// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Manager : Employee
    {
        // class variables
        private int numberOfEmployeesManaged = -1;
        
        // gets and sets
        public int NumberOfEmployeesManaged
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }

        // constructors
        public Manager(string aName, double aSalary, int aNumOfEmployeesManaged) : base(aName, aSalary)
        {
            this.NumberOfEmployeesManaged = aNumOfEmployeesManaged;
        }
        public Manager() : this("unknown", 0, -1) { }

        // class methods
        public override string ToString()
        {
            return base.ToString() + $", Manager of {this.NumberOfEmployeesManaged} employees";
        }
    }
}
