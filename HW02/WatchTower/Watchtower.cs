// Written by James Jang
// 02/03/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower
{
    public class Watchtower
    {
        // private variables
        private int[] enemyLocation = new int[2];

        // gets and sets
        public int[] EnemyLocation
        {
            get { return this.enemyLocation; }
            set { this.enemyLocation = value; }
        }

        // constructors
        public Watchtower(int xCoordinate, int yCoordinate)
        {
            this.enemyLocation[0] = xCoordinate;
            this.enemyLocation[1] = yCoordinate;
        }
        public Watchtower() : this(0, 0) { }

        // class methods
        public string AlertAttack()
        {
            string enemyDirection = "";
            if (EnemyLocation[1] > 0)
            {
                enemyDirection += "north";
            }
            else if (EnemyLocation[1] < 0)
            {
                enemyDirection += "south";
            }
            if (EnemyLocation[0] > 0)
            {
                enemyDirection += "east";
            }
            if (EnemyLocation[0] < 0)
            {
                enemyDirection += "west";
            }

            if (enemyDirection == "") return "The enemy is here!";
            
            return "The enemy is to the " + enemyDirection + "!";
        }
    }
}
