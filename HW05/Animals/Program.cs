// Written by James Jang
// 02/24/2025

namespace Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog aDog = new Dog("cat");
            Cat aCat = new Cat("dog");
            Console.WriteLine(aDog);
            Console.WriteLine(aCat);
        }
    }
}
