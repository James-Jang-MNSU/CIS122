// Written by James Jang
// 01/27/2025

namespace TheTriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter height (integer value please): ");
            int inputHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter base (integer value please): ");
            int inputBase = Convert.ToInt32(Console.ReadLine());
            Triangle aTriangle = new Triangle(inputHeight, inputBase);
            Console.WriteLine("Area of triangle: " + aTriangle.AreaOfTriangle() + "\n");
        }
    }
}
