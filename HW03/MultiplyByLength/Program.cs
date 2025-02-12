// Written by James Jang
// 02/11/2025

namespace MultiplyByLength
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            int[] anArrayOfNumbers = { 2, 3, 1, 0 };
            int[] modifiedArrayOfNumebers = aCalculator.MultiplyByLength(anArrayOfNumbers);
            Console.Write("[ ");
            foreach (int number in modifiedArrayOfNumebers) { Console.Write(number + ", "); }
            Console.WriteLine("\b\b ]");
        }
    }
}
