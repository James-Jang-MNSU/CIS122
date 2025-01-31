// Written by James Jang
// 01/28/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseOfConsolas
{
    public class MagicalBarrier
    {
        // class variables
        private List<int> target = new List<int>([-1, -1]);
        
        // gets and sets
        public List<int> Target
        {
            get { return this.target; }
            set { this.target = value; }
        }
        // squad members are read-only
        

        // constructors 
        public MagicalBarrier(int aTargetRow, int aTargetColumn)
        {
            this.target = new List<int>([aTargetRow, aTargetColumn]);
        }
        public MagicalBarrier(): this(-1, -1) { }

        // class methods
        public List<int> DeploySquadMemberN()
        {
            List<int> squadMemberN = new List<int>([Target[0] + 1, Target[1]]);
            return squadMemberN;
        }
        public List<int> DeploySquadMemberS()
        {
            List<int> squadMemberS = new List<int>([Target[0] - 1, Target[1]]);
            return squadMemberS;
        }
        public List<int> DeploySquadMemberW()
        {
            List<int> squadMemberW = new List<int>([Target[0], Target[1] - 1]);
            return squadMemberW;
        }
        public List<int> DeploySquadMemberE()
        {
            List<int> squadMemberE = new List<int>([Target[0], Target[1] + 1]);
            return squadMemberE;
        }
        /*
        public List<int> SquadMemberN()
        {
            return new List<int>([Target[0] + 1, Target[1]]);
        }
        public List<int> SquadMemberS()
        {
            return new List<int>([Target[0] - 1, Target[1]]);
        }
        public List<int> SquadMemberW()
        {
            return new List<int>([Target[0], Target[1] - 1]);
        }
        public List<int> SquadMemberE()
        {
            return new List<int>([Target[0], Target[1] + 1]);
        }
        */
        public override string ToString()
        {
            List<int> squadMemberN = DeploySquadMemberN();
            List<int> squadMemberS = DeploySquadMemberS();
            List<int> squadMemberW = DeploySquadMemberW();
            List<int> squadMemberE = DeploySquadMemberE();
            return $"Current target: ({Target[0]},{Target[1]})\n"
                + "Deploy to:\n"
                + $"\t({squadMemberW[0]}, {squadMemberW[1]})\n"
                + $"\t({squadMemberS[0]}, {squadMemberS[1]})\n"
                + $"\t({squadMemberE[0]}, {squadMemberE[1]})\n"
                + $"\t({squadMemberN[0]}, {squadMemberN[1]})";



        }
    }
}
