// Written by James Jang
// 01/27/2025

namespace DominionOfKings
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of provinces: ");
            int aNumOfProvinces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of duchies: ");
            int aNumOfDuchies = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of estates: ");
            int aNumOfEstates = Convert.ToInt32(Console.ReadLine());
            Kingdom aKingdom = new Kingdom(aNumOfProvinces, aNumOfDuchies, aNumOfEstates);
            Console.WriteLine("Point total: " + aKingdom.CalcKindomPoints() + "\n");
            Console.WriteLine(aKingdom);
        }
    }
}
