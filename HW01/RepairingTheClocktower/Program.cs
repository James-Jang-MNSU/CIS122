// Written by James Jang
// 01/28/2025

namespace RepairingTheClocktower
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of seconds (between 0 and 60): ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            ClockTower aClockTower = new ClockTower(inputNumber);
            Console.WriteLine(aClockTower.TickOrTock());
        }
    }
}
