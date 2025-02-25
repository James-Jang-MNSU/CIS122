// Written by James Jang
// 02/24/2025

namespace LibrarySystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EBook aEbook = new EBook("Factfulness", "Hans Rosling", "04/03/2018", 4.6);
            PrintedBook aPrintedBook = new PrintedBook("Harry Potter and the Sorcerer's Stone", "J K Rowling", "07/26/1996", 320);
            Console.WriteLine(aEbook);
            Console.WriteLine(aPrintedBook);
        }
    }
}
