// Written by James Jang
// 02/23/2025

namespace VehiclesCars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car aCar = new Car("Ford", "Mustang", 1965, 2);
            Motorcycle aMotorcycle = new Motorcycle("Honda", "CB750", 1969, false);
            Console.WriteLine(aCar.ToString());
            Console.WriteLine(aMotorcycle.ToString());  
        }
    }
}
