// Written by James Jang
// 02/11/2025

namespace PropertiesOfArrows
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Select your arrow head type (steel/wood/obsidian): ");
            string userHeadType = Console.ReadLine();
            Console.Write("Select your arrow length (60-100): ");
            int userLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Select your arrow fletching type (plastic/turkey feathers/goose feathers): ");
            string userFletchingType = Console.ReadLine();
            Arrow userArrow = new Arrow(userHeadType, userLength, userFletchingType);
            Console.WriteLine($"Your arrow costs {userArrow.GetCost()} gold");
        }
    }
}
