// Written by James Jang
// 01/28/2025

namespace DefenseOfConsolas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";

            Console.Write("Enter target row: ");
            int targetRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter target column: ");
            int targetColumn = Convert.ToInt32(Console.ReadLine());
            MagicalBarrier aBarrier = new MagicalBarrier(targetRow, targetColumn);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.WriteLine(aBarrier);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
