// Written by James Jang
// 02/11/2025

namespace SmallerNum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            Console.Write("Enter an integer: ");
            string userNum1 = Console.ReadLine();
            Console.Write("Enter another integer: ");
            string userNum2 = Console.ReadLine();
            Console.WriteLine($"The smaller number is {aCalculator.SmallerNum(userNum1, userNum2)}");
        }
    }
}
