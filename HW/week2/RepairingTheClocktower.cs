//Written by James Jang
// 01/26/2025

using System;

namespace RepairingTheClocktower
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repairing the Clocktower
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        }

    }
}