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

        public Player()
        {
            Console.WriteLine("please enter your name: ");
            name = Console.ReadLine();

            money = 20.00;

            inventory = new Inventory();
            inventory.cups.count = 0;
            inventory.lemons.count = 0;
            inventory.sugar.count = 0;
            inventory.ice.count = 0;

            recipe = new Recipe();
        }


    }
}
