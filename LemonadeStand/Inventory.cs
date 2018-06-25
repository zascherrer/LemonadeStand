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

        }
    }
}
