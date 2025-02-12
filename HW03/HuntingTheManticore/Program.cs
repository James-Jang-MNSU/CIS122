// Written by James Jang
// 02/11/2025

namespace HuntingTheManticore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Player 1, how far away from the city do you want to station the Manticore? (Choose between 0-100) ");
            int aDistance = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Player 2, it is your turn.");

            Manticore player1 = new Manticore(aDistance);
            CityOfConsolas player2 = new CityOfConsolas();

            int roundCount = 1;
            while (player1.Health > 0 && player2.Health > 0)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"STATUS: ROUND: {roundCount} City: {player2.Health}/{player2.MaxHealth} Manticore: {player1.Health}/{player1.MaxHealth}");
                Console.WriteLine($"The cannon is expected to deal {player2.GetCannonDamage(roundCount)} damage this round.");
                Console.Write("Enter desired cannon range: ");
                int player2Aim = Convert.ToInt32(Console.ReadLine());
                if (player2Aim > player1.DistanceFromCity)
                {
                    Console.WriteLine("That round OVERSHOT the target.");
                    player2.TakeDamage(player2.GetCannonDamage(roundCount));
                }
                else if (player2Aim < player1.DistanceFromCity)
                {
                    Console.WriteLine("That round FELL SHORT of the target.");
                    player2.TakeDamage(player2.GetCannonDamage(roundCount));
                }
                else
                {
                    Console.WriteLine("That round was a DIRECT HIT!");
                    player1.TakeDamage(player2.GetCannonDamage(roundCount));
                }
                roundCount++;
            }
            
            if (player1.Health >= 0)
            {
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            }
            if (player2.Health >= 0)
            {
                Console.WriteLine("GAMEOVER The Manticore has destoryed the city of Consolas");
            }
        }
    }
}
