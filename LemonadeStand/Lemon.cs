using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon : Item
    {

        public Lemon()
        {
            name = "Lemon";
            canSpoil = true;
            count = 15;
            price = 0.10;
            spoilageChance = 0.10;
        }
    }
}
