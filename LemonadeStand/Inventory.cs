using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public Cup cups;
        public Lemon lemons;
        public Sugar sugar;
        public Ice ice;

        public Inventory()
        {
            cups = new Cup();
            lemons = new Lemon();
            sugar = new Sugar();
            ice = new Ice();
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\n\n" +
                "Cups: {0} \n" +
                "Lemons: {1} \n" +
                "Sugar: {2} \n" +
                "Ice Cubes: {3} \n\n",
                cups.count, lemons.count, sugar.count, ice.count);
        }

        public void SpoilInventory(Random random)
        {
            cups.SpoilItem(random);
            lemons.SpoilItem(random);
            sugar.SpoilItem(random);
            ice.SpoilItem(random);
        }
    }
}
