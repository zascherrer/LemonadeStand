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

        public void DayStartMenu(Player player, Store store)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("" +
                    "It is currently day X. \n" +
                    "The weather should be Y today. \n" +
                    "What would you like to do next? \n" +
                    " 1. Display Money and Inventory \n" +
                    " 2. Buy Cups \n" +
                    " 3. Buy Lemons \n" +
                    " 4. Buy Sugar \n" +
                    " 5. Buy Ice Cubes \n" +
                    " 0. Start Day! \n");
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
                    case "0":
                        return;
                    default:
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
