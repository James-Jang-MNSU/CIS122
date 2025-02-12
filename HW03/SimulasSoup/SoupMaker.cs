// Written by James Jang
// 02/11/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasSoup
{
    public class SoupMaker
    {
        // class variables
        enum SoupType { Soup, Gumbo, Stew };
        enum MainIngredient { Mushroom, Chicken, Carrots, Potatoes };
        enum Seasoning { Sweet, Salty, Spicy };

        // class methods
        public void MakeSoup()
        {
            Console.Write("Please select the type (1 - soup, 2 - gumbo, 3 - stew): ");
            int aSoupType = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please select the main ingredient (1 - mushroom, 2 - chicken, 3 - carrots, 4 - potatoes): ");
            int aMainIngredient= Convert.ToInt32(Console.ReadLine());
            Console.Write("Please select the seasoning (1 - sweet, 2 - salty, 3 - spicy): ");
            int aSeasoning = Convert.ToInt32(Console.ReadLine());

            SoupType userType = aSoupType switch
            {
                1 => SoupType.Soup,
                2 => SoupType.Gumbo,
                3 => SoupType.Stew
            };
            MainIngredient userIngredient = aSoupType switch
            {
                1 => MainIngredient.Mushroom,
                2 => MainIngredient.Chicken,
                3 => MainIngredient.Carrots,
                4 => MainIngredient.Potatoes   
            };
            Seasoning userSeasoning = aSeasoning switch 
            { 
                1 => Seasoning.Sweet,
                2 => Seasoning.Salty,
                3 => Seasoning.Spicy
            };

            Console.WriteLine($"{userSeasoning} {userIngredient} {userType}");
        }
    }
}
