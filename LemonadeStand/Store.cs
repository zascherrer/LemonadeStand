using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        Inventory inventory;

        public Store()
        {
            inventory = new Inventory();
        }

        public void BuyItem(Player player, Item item)
        {
            double basePriceTotal;
            double bulkPriceTotal;
            double superBulkPriceTotal;

            int bulkCountModifier = 2;
            int superBulkCountModifier = 4;

            string userInput = "";
            bool validInput = false;

            basePriceTotal = item.price * item.count;
            bulkPriceTotal = item.price * (item.count * bulkCountModifier) * 0.8;
            superBulkPriceTotal = item.price * (item.count * superBulkCountModifier) * 0.6;

            while (!validInput)
            {
                player.inventory.DisplayInventory();

                Console.WriteLine("\n\n" +
                    "Would you like to buy: \n" +
                    " 1. {0} {1}s for ${2} \n" +
                    " 2. {3} {1}s for ${4} \n" +
                    " 3. {5} {1}s for ${6} \n" +
                    " 4. Exit",
                    item.count, item.name, basePriceTotal,
                    (item.count * bulkCountModifier), bulkPriceTotal,
                    (item.count * superBulkCountModifier), superBulkPriceTotal);

                userInput = Console.ReadLine();
                validInput = ValidateShopInput(userInput);
            }

            switch (userInput)
            {
                case "1":
                    FinalizeTransaction(player, item.name, basePriceTotal, item.count);
                    break;
                case "2":
                    FinalizeTransaction(player, item.name, bulkPriceTotal, item.count * bulkCountModifier);
                    break;
                case "3":
                    FinalizeTransaction(player, item.name, superBulkPriceTotal, item.count * superBulkCountModifier);
                    break;
            }
        }

        private bool ValidateShopInput(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "4":
                    return true;
                default:
                    return false;
            }
        }

        private void FinalizeTransaction(Player player, string itemName, double price, int howMany)
        {
            player.money -= price;

            switch (itemName)
            {
                case "Cup":
                    player.inventory.cups.count += howMany;
                    break;
                case "Lemon":
                    player.inventory.lemons.count += howMany;
                    break;
                case "Sugar":
                    player.inventory.sugar.count += howMany;
                    break;
                case "Ice Cube":
                    player.inventory.ice.count += howMany;
                    break;
                default:
                    break;
            }

            DisplayTransactionResults(player);
        }

        private void DisplayTransactionResults(Player player)
        {
            Console.WriteLine("\n\nYou have ${0} remaining. Your current inventory is: \n", player.money);
            player.inventory.DisplayInventory();
        }

    }
}
