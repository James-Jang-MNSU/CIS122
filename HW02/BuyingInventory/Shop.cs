// Written by James Jang
// 02/03/2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingInventory
{
    public class Shop
    {
        // class variables
        private Dictionary<string, int> itemDict = new Dictionary<string, int>();

        // gets and sets
        public Dictionary<string, int> ItemDict
        {
            get { return this.itemDict; }
            // readonly
        }

        // constructors
        public Shop()
        {
            this.itemDict = new Dictionary<string, int>();
            this.itemDict["Rope"] = 10;
            this.itemDict["Torches"] = 16;
            this.itemDict["Climbing Equipment"] = 24;
            this.itemDict["Clean Water"] = 2;
            this.itemDict["Machete"] = 20;
            this.itemDict["Canoe"] = 200;
            this.itemDict["Food Supplies"] = 2;

        }

        // class methods
        public string GetMenu()
        {
            string prompt = "The following items are available:\n";
            int itemCount = 1;
            foreach (KeyValuePair<string, int> entry in ItemDict)
            {
                prompt += itemCount + " - " + entry.Key + "\n";
                itemCount++;
            }
            return prompt;
        }

        public string GetItemCost(int customerChoice)
        {
            string item;
            switch (customerChoice)
            {
                case 1:
                    item = "Rope";
                    break;
                case 2:
                    item = "Torches";
                    break;
                case 3:
                    item = "Climbing Equipment";
                    break;
                case 4:
                    item = "Clean Water";
                    break;
                case 5:
                    item = "Machete";
                    break;
                case 6:
                    item = "Canoe";
                    break;
                case 7:
                    item = "Food Supplies";
                    break;
                default:
                    return "Please choose between";
            }
            return $"{item} cost {ItemDict[item]} gold.";
        }

    }
}
