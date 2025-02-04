// Written by James Jang
// 02/04/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCannon
{
    public class MagicCannon
    {
        // class variables
        private int fireGemCycle = -1;
        private int electricGemCycle = -1;

        // gets and sets
        public int FireGemCycle
        {
            get { return this.fireGemCycle; }
            // readonly
        }
        public int ElectricGemCycle
        {
            get { return this.electricGemCycle; }
            // readonly
        }

        // constructors
        public MagicCannon(int aFireGemCycle, int anElectricGemCycle) 
        {
            if (aFireGemCycle > 0) this.fireGemCycle = aFireGemCycle;
            if (anElectricGemCycle > 0) this.electricGemCycle = anElectricGemCycle;
        }

        // class methods
        public void BlastCannonSingle(int blastCount)
        {
            if (blastCount % FireGemCycle == 0)
            {
                if (blastCount % ElectricGemCycle == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{blastCount}: Electric and Fire");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{blastCount}: Fire");
                }
            }
            else
            {
                if (blastCount % ElectricGemCycle == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{blastCount}: Electric");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{blastCount}: Normal");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void BlastCannonMultiple(int aNumOfBlasts)
        {
            for (int i = 1; i <= aNumOfBlasts; i++)
            {
                BlastCannonSingle(i);
            }
        }
    }
}
