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

        public Game()
        {
            Console.WriteLine("Welcome to Lemonade Stand,");
            playerOne = new Player();

            store = new Store();

        }

        public void RunGame()
        {
            store.BuyItem(playerOne, new Cup());

            Console.ReadLine();
        }
    }
}
