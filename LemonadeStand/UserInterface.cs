using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {

        public UserInterface()
        {

        }

        public void DayStartMenu(Player player, Store store, Recipe recipe, Weather weather, List<Day> days)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("" +
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
                    days.Count+1, weather.Temperature, weather.weatherEffect);
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("\n\nYou have ${0} remaining. Your current inventory is: \n", String.Format("{0:0.00}", player.money));
                        player.inventory.DisplayInventory();
                        break;
                    case "2":
                        store.BuyItem(player, new Cup());
                        break;
                    case "3":
                        store.BuyItem(player, new Lemon());
                        break;
                    case "4":
                        store.BuyItem(player, new Sugar());
                        break;
                    case "5":
                        store.BuyItem(player, new Ice());
                        break;
                    case "6":
                        recipe.DisplayRecipe();
                        break;
                    case "7":
                        recipe.ChangeRecipe();
                        break;
                    case "8":
                        recipe.ChangePrice();
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }

                Console.ReadLine();
            }
        }

        public void EndGameMenu(Player player, List<Day> days)
        {
            Console.Clear();
            Console.WriteLine("" +
                "Game over! \n\n" +
                "You made a total of ${0} over {1} days. \n" +
                "That's an average of ${2} per day!",
                String.Format("{0:0.00}", player.money - 20), days.Count, String.Format("{0:0.00}", (player.money - 20) / days.Count));
        }
    }
}
