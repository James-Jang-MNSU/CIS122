//Written by James Jang
// 01/26/2025

using System;

namespace DefenseOfConsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Defense of Consolas
            Console.Title = "Defense of Consolas";
            Console.Write("Enter target row: ");
            int targetRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter target column: ");
            int targetColumn = Convert.ToInt32(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.WriteLine("Deploy to: \n" + $"({targetRow + 1},{targetColumn})\n"
                + $"({targetRow - 1},{targetColumn})\n"
                + $"({targetRow},{targetColumn + 1})\n"
                + $"({targetRow},{targetColumn - 1})\n");
        }

    }
}