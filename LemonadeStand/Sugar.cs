using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Item
    {

        public Sugar()
        {
            name = "Sugar";
            canSpoil = false;
            count = 10;
            price = 0.08;
        }
    }
}
