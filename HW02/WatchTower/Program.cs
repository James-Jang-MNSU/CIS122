// Written by James Jang
// 02/03/2025

namespace WatchTower
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter x value: ");
            int aXValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y value: ");
            int aYValue = Convert.ToInt32(Console.ReadLine());
            Watchtower aWatchtower = new Watchtower(aXValue, aYValue);
            Console.WriteLine(aWatchtower.AlertAttack());
        }
    }
}
