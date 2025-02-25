// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        // class variables
        private string name = "n/a";
        private double salary = double.MinValue;
    
        // gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        // constructors
        public Employee(string aName, double aSalary)
        {
            this.Name = aName;
            this.Salary = aSalary;
        }
        public Employee() : this("unkown", 0) { }

        // class methods

        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: ${this.Salary}";
        }
    }
}
