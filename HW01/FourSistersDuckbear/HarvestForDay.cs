// Written by James Jang
// 01/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSistersDuckbear
{
    public class HarvestForDay
    {
        // class variables
        private int totalChocolateEgss = -1;

        // gets and sets
        public int TotalChocolateEgss
        {
            get { return totalChocolateEgss; }
            set { totalChocolateEgss = value; }
        }

        // constructors
        public HarvestForDay(int aNumOfChocolateEgss)
        {
            this.totalChocolateEgss = aNumOfChocolateEgss;
        }

        public HarvestForDay() : this(0) { }

        // class methods
        public int EggsForDuckbear()
        {
            return totalChocolateEgss % 4;
        }
        public int EggsPerPerson()
        {
            return (totalChocolateEgss - EggsForDuckbear()) / 4;
        }

    }
}
