using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cup : Item
    {

        public Cup()
        {
            name = "Cup";
            canSpoil = false;
            count = 25;
            price = 0.05;
        }

    }
}
