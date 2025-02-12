// Written by James Jang
// 02/10/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimulasTest
{
    public class Chest
    {
        // class variables
        public enum ChestStatus { Open, Closed, Locked };
        private ChestStatus current = ChestStatus.Locked; 

        // gets and sets
        public ChestStatus Current
        {
            get { return this.current; }
            set { this.current = value; }
        }

        // class methods
        public void ManipulateChest()
        {
            string prompt;
            string userResponse;
            prompt = Current switch
            {
                ChestStatus.Locked => "The chest is locked. What do you want to do? ",
                ChestStatus.Closed => "The chest is unlocked. What do you want to do? ",
                ChestStatus.Open => "The chest is open. What do you want to do? "
            };
            Console.Write(prompt);
            userResponse = Console.ReadLine();
            if (userResponse != "unlock" && userResponse != "lock" && userResponse != "close" && userResponse != "open")
            {
                Console.WriteLine("Sorry, don't know that one!");
                return;
            }
            if (userResponse == "unlock" && Current == ChestStatus.Locked)
            {
                Current = ChestStatus.Closed;
            }
            else if (userResponse == "open" && Current == ChestStatus.Closed)
            {
                Current = ChestStatus.Open;
            }
            else if (userResponse == "close" && Current == ChestStatus.Open)
            {
                Current = ChestStatus.Closed;
            }
            else if (userResponse == "lock" && Current == ChestStatus.Closed)
            {
                Current = ChestStatus.Locked;
            }
            else
            {
                return;
            }

        }
    }
}
