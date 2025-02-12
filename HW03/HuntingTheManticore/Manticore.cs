// Written by James Jang
// 02/11/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingTheManticore
{
    public class Manticore
    {
        // class variabels
        private int maxHealth = 10; // hard coded to the value given in the book
        private int health = 10; 
        private int distanceFromCity = -1;

        // gets and sets
        public int MaxHealth
        {
            get { return maxHealth; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int DistanceFromCity
        {
            get { return distanceFromCity; }
        }

        // constructor
        public Manticore(int aDistance)
        {
            this.distanceFromCity = aDistance;
        }

        // class methods
        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
        }
    }
}
