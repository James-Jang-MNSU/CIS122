// Written by James Jang
// 02/04/2025

namespace ReplicatorOfDTo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers for your array");
            int arrayEntry1 = Convert.ToInt32(Console.ReadLine());
            int arrayEntry2 = Convert.ToInt32(Console.ReadLine());
            int arrayEntry3 = Convert.ToInt32(Console.ReadLine());
            int arrayEntry4 = Convert.ToInt32(Console.ReadLine());
            int arrayEntry5 = Convert.ToInt32(Console.ReadLine());
            ReplicatorOfDTo aReplicator = new ReplicatorOfDTo(arrayEntry1, arrayEntry2, arrayEntry3, arrayEntry4, arrayEntry5);
            aReplicator.ReplicateArray();

        }
    }
}
