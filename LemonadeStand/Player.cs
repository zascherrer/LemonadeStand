using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public double money;
        public Inventory inventory;
        public Recipe recipe;
        private Pitcher pitcher;
        public bool soldOut;
        public int cupsSold;

        public Player()
        {
            Console.WriteLine("please enter your name: ");
            name = Console.ReadLine();

            money = 20.00;
            soldOut = false;
            cupsSold = 0;

            inventory = new Inventory();
            inventory.cups.count = 0;
            inventory.lemons.count = 0;
            inventory.sugar.count = 0;
            inventory.ice.count = 0;

            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        public void SellLemonade()
        {
            money += recipe.price;
            cupsSold++;

            if(pitcher.cupsLeft == 0 && inventory.lemons.count >= recipe.recipe.lemons.count && inventory.sugar.count >= recipe.recipe.sugar.count)
            {
                RefillPitcher();
            }
            else if(pitcher.cupsLeft == 0 && (inventory.lemons.count < recipe.recipe.lemons.count || inventory.sugar.count < recipe.recipe.sugar.count))
            {
                soldOut = true;
            }

            inventory.cups.count -= recipe.recipe.cups.count;
            inventory.ice.count -= recipe.recipe.ice.count;

            if(inventory.cups.count <= 0)
            {
                inventory.cups.count = 0;
                soldOut = true;
            }
            if(inventory.ice.count <= 0)
            {
                inventory.ice.count = 0;
                soldOut = true;
            }
        }

        private void RefillPitcher()
        {
            pitcher.cupsLeft = pitcher.maximumCups;

            inventory.lemons.count -= recipe.recipe.lemons.count;
            inventory.sugar.count -= recipe.recipe.sugar.count;
        }
    }
}
