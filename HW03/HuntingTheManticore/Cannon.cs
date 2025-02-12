// Written by James Jang
// 02/11/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingTheManticore
{
    public class Cannon
    {
        // class variables
        private int fireGemCycle = -1;
        private int elecGemCycle = -1;
        private int cannonRange = -1;

        // gets and sets
        public int FireGemCycle
        {
            get { return this.fireGemCycle; }
            set { this.fireGemCycle = value; }
        }
        public int ElecGemCycle
        {
            get { return this.elecGemCycle; }
            set { this.elecGemCycle = value; }
        }
        public int CannonRange
        {
            get { return this.cannonRange; }
            set { this.cannonRange = value; }
        }

        // constructors
        public Cannon(int gemCycle1, int gemCycle2)
        {
            this.fireGemCycle = gemCycle1;
            this.elecGemCycle = gemCycle2;
        }

        // class methods
        public int CalcDamage(int roundNumber)
        {
            if (roundNumber % FireGemCycle == 0 && roundNumber % ElecGemCycle == 0)
            {
                return 10;
            }
            else if (roundNumber % FireGemCycle == 0)
            {
                return 3;
            }
            else if (roundNumber % ElecGemCycle == 0)
            {
                return 5;
            }
            else
            {
                return 1;
            }
        }
    }
}
