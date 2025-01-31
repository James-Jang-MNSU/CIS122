// Written by James Jang
// 01/27/2025

namespace FourSistersDuckbear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of chocolate eggs: ");
            int numOfEggs = Convert.ToInt32(Console.ReadLine());
            HarvestForDay aHarvestForDay = new HarvestForDay(numOfEggs);
            Console.WriteLine("Eggs per person: " + aHarvestForDay.EggsPerPerson());
            Console.WriteLine("Eggs for duckbear: " + aHarvestForDay.EggsForDuckbear() + "\n");
        }
    }
}
