// Written James Jang
// 02/04/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplicatorOfDTo
{
    public class ReplicatorOfDTo
    {
        // class variables
        private int[] originalArray;

        // gets and sets
        public int[] OriginalArray
        {
            get { return this.originalArray; }
            set { this.originalArray = value; }
        }

        // constructors
        public ReplicatorOfDTo(int num1, int num2, int num3, int num4, int num5)
        {
            this.originalArray = new int[] {num1, num2, num3, num4, num5};
        }
        
        // class methods
        public void ReplicateArray()
        {
            int[] replica = new int[originalArray.Length];
            for (int i = 0; i < originalArray.Length; i++)
            {
                replica[i] = OriginalArray[i]; 
            }
            Console.WriteLine("Index\tOriginal\tReplica");
            for (int i = 0; i < replica.Length; i++)
            {
                Console.WriteLine($"{i}\t{OriginalArray[i]}\t\t{replica[i]}");
            }
        }
        
    }
}
