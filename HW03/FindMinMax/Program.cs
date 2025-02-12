// Written by James Jang
// 02/11/2025

namespace FindMinMax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            int[] anArrayOfNumbers = { 1, 2, 3, 4, 5 };
            (int minimum, int maximum) = aCalculator.FindMinMax(anArrayOfNumbers);
            Console.WriteLine($"minimum: {minimum}, maximum: {maximum}");
        }
    }
}
