// Written by James Jang
// 02/11/2025 

namespace GetAbsSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            int[] anArrayOfNumebrs = { -3, -4, -10, -2, -3 };
            Console.WriteLine(aCalculator.GetAbsSum(anArrayOfNumebrs));
        }
    }
}
