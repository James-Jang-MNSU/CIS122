﻿// Written by James Jang
// 02/03/2025

namespace BuyingInventory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shop aShop = new Shop();
            Console.WriteLine(aShop.GetMenu());
            Console.Write("What number do you want to see the price of? ");
            int customerChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(aShop.GetItemCost(customerChoice));            
        }
    }
}
