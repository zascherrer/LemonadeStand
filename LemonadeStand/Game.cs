using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player playerOne;
        Store store;
        UserInterface ui;

        public Game()
        {
            Console.WriteLine("Welcome to Lemonade Stand,");
            playerOne = new Player();

            store = new Store();
            ui = new UserInterface();

        }

        public void RunGame()
        {
            playerOne.soldOut = false;
            ui.DayStartMenu(playerOne, store, playerOne.recipe);

            Console.ReadLine();
        }
    }
}
