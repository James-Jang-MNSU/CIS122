// Written James Jang
// 02/04/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrototype
{
    public class TargetLocater
    {
        // class variables
        private int targetLocation = int.MaxValue;

        // gets and sets
        public int TargetLocation
        {
            get { return this.targetLocation; }
            // readonly
        }

        // constructors - full constructor only
        public TargetLocater(int aLocation) 
        { 
            if (aLocation >= 0 && aLocation <= 100)
            {
                this.targetLocation = aLocation;
            }
        }

        // class methods
        public void GuessLocation()
        {
            Console.Write("Guess the location of the target: ");
            int huntersGuess = Convert.ToInt32(Console.ReadLine());
            while (huntersGuess != TargetLocation)
            {
                if (huntersGuess > TargetLocation)
                {
                    Console.Write($"{huntersGuess} is too high! Try again: ");
                }
                else
                {
                    Console.Write($"{huntersGuess} is too low! Try again: ");
                }
                huntersGuess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You've located the target!");
        }
    }
}
