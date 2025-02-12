// Written by James Jang
// 02/11/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingTheManticore
{
    public class CityOfConsolas
    {
        // class variabels
        private int maxHealth = 15; // hard coded to the value given in the book
        private int health = 15; 
        private Cannon skorkinsCannon = new Cannon(3, 5); // hard coded to values that are given in the book

        // gets and sets
        public int MaxHealth
        {
            get { return this.maxHealth; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        // class methods
        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
        }
        public void ChangeRangeTo(int newRange)
        {
            skorkinsCannon.CannonRange = newRange;
        }
        public int GetCannonDamage(int roundNumber)
        {
            return skorkinsCannon.CalcDamage(roundNumber);
        }
    }
}
