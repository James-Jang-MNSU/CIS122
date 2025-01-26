//Written by James Jang
// 01/26/2025

using System;

namespace FourSistersDuckbear
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Four Sisters and the Duckbear
            int eggsPerPerson;
            int eggsForDuckbear;
            Console.Write("Enter number of chocolate eggs: ");
            int numOfEggs = Convert.ToInt32(Console.ReadLine());
            eggsForDuckbear = numOfEggs % 4;
            eggsPerPerson = (numOfEggs - eggsForDuckbear) / 4;
            Console.WriteLine("Eggs per person: " + eggsPerPerson);
            Console.WriteLine("Eggs for duckbear: " + eggsForDuckbear + "\n");
        }

    }
}