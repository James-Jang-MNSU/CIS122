// Written by James Jang
// 01/28/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheClocktower
{
    public class ClockTower
    {
        // class variables
        private int seconds = -1;
        
        // gets and sets
        public int Seconds
        {
            get { return this.seconds; }
            set { if (value >= 0 && value <= 60) this.seconds = value; }
        }

        // constructors
        public ClockTower(int aNumOfSeconds)
        {
            if (aNumOfSeconds >= 0 && aNumOfSeconds <= 60) this.seconds = aNumOfSeconds;
        }

        // class methods
        public string TickOrTock()
        {
            if (seconds % 2  == 0)
            {
                return "tick";
            }
            else
            {
                return "tock";
            }
        }


    }
}
