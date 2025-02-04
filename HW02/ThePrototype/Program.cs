// Written James Jang
// 02/04/2025

namespace ThePrototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Locate the airship: ");
            int airshipLocation = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            TargetLocater aTargetLocater = new TargetLocater(airshipLocation);
            aTargetLocater.GuessLocation();
        }
    }
}
