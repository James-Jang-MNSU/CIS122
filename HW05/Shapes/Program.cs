// Written by James Jang
// 02/24/2025

namespace Shapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Rectangle aRectangle = new Rectangle("Blue", 3, 4);
            Circle aCircle = new Circle("Green", 5);
            Console.WriteLine(aRectangle);
            Console.WriteLine(aCircle);
        }
    }
}
