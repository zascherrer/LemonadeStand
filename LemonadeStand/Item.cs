using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {
        public string name;
        public bool canSpoil;
        public int count;
        public double price;
        public double spoilageChance;

        public Item()
        {
            name = "Wrench";
            canSpoil = false;
            count = 0;
            price = 1.00;
        }

    }
}
