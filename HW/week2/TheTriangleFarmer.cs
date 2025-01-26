//Written by James Jang
// 01/26/2025

using System;

namespace TheTriangleFarmer
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Triangle Farmer
            int areaOfTriangle;
            Console.Write("Enter height: ");
            int inputHeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter base: ");
            int inputBase = Convert.ToInt32(Console.ReadLine());
            areaOfTriangle = inputHeight * inputBase / 2;
            Console.WriteLine("Area of triangle: " + areaOfTriangle + "\n");
        }

    }
}