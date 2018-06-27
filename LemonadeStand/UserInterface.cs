using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {

        public void DayStartMenu(Player player, Store store, Recipe recipe, Weather weather, int days)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("{3}'s Lemonade Stand: \n\n" +
                    "It is currently day {0}. \n" +
                    "It should be {1} degrees and {2} today. \n" +
                    "What would you like to do next? \n" +
                    " 1. Display Money and Inventory \n" +
                    " 2. Buy Cups \n" +
                    " 3. Buy Lemons \n" +
                    " 4. Buy Sugar \n" +
                    " 5. Buy Ice Cubes \n" +
                    " 6. Display Lemonade Recipe \n" +
                    " 7. Change Lemonade Recipe \n" +
                    " 8. Change Price per Cup \n" +
                    " 0. Start Day! \n",
                    days, weather.Temperature, weather.weatherEffect, player.name);
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("\n\nYou have ${0} remaining. Your current inventory is: \n", String.Format("{0:0.00}", player.money));
                        player.inventory.DisplayInventory();
                        Console.ReadLine();
                        break;
                    case "2":
                        store.BuyItem(player, new Cup());
                        Console.ReadLine();
                        break;
                    case "3":
                        store.BuyItem(player, new Lemon());
                        Console.ReadLine();
                        break;
                    case "4":
                        store.BuyItem(player, new Sugar());
                        Console.ReadLine();
                        break;
                    case "5":
                        store.BuyItem(player, new Ice());
                        Console.ReadLine();
                        break;
                    case "6":
                        recipe.DisplayRecipe();
                        Console.ReadLine();
                        break;
                    case "7":
                        recipe.ChangeRecipe();
                        Console.ReadLine();
                        break;
                    case "8":
                        recipe.ChangePrice();
                        Console.ReadLine();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("\n\nYour input was invalid. Press Enter to return to the menu.\n\n");
                        Console.ReadLine();
                        break;
                }
                

            }
        }

        public void EndGameMenu(Player player, int days)
        {
            
            Console.WriteLine("" +
                "{3} made a total of ${0} over {1} days. \n" +
                "That's an average of ${2} per day!\n\n",
                String.Format("{0:0.00}", player.money - 20), days, String.Format("{0:0.00}", (player.money - 20) / days), player.name);
            
        }
    }
}
