// Written by James Jang
// 02/18/2025

namespace StringProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution aSolution = new Solution();

            // 1. wordCount
            string testCase1 = "Just an example here move along";
            Console.WriteLine(aSolution.countWords(testCase1));

            // 2. flipEndChars
            string testCase2 = "Cat, dog, and mouse.";
            Console.WriteLine(aSolution.flipEndChars(testCase2));

            // 3. isInOrder
            string testCase3 = "abecd";
            Console.WriteLine(aSolution.isInOrder(testCase3));

            // 4. firstNVowels
            string testCase4 = "major league";
            Console.WriteLine(aSolution.firstNVowels(testCase4, 3));

            // 5. move
            string testCase5 = "hello";
            Console.WriteLine(aSolution.move(testCase5));
        }
    }
}
