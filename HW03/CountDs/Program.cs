// Written by James Jang
// 02/11/2025

namespace CountDs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Counter aCounter = new Counter();
            string testString = "My friend Dylan got distracted in school.";
            Console.WriteLine(aCounter.CountDs(testString));
        }
    }
}
