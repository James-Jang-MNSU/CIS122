// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        // class variables
        protected string name = "n/a";

        // gets and sets
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructor
        public Animal(string aName)
        {
            this.Name = aName;
        }
        public Animal() : this("unknown") { }

        // class methods
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }
        public override string ToString()
        {
            return $"Animal: {this.Name}, Sound: {this.MakeSound()}";
        }
    }
}
