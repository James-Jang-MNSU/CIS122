//Written by James Jang
// 01/26/2025

using System;

namespace DominionOfKings
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Dominion of Kings 
            int totalPoints;
            Console.Write("Enter number of provinces: ");
            int numOfProvinces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of duchies: ");
            int numOfDuchies = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of estates: ");
            int numOfEstates = Convert.ToInt32(Console.ReadLine());
            totalPoints = numOfProvinces * 6 + numOfDuchies * 3 + numOfEstates;
            Console.WriteLine("Point total: " + totalPoints + "\n");
        }

    }
}