﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice : Item
    {

        public Ice()
        {
            name = "Ice Cube";
            canSpoil = true;
            count = 100;
            price = 0.01;
            spoilageChance = 0.90;
        }
    }
}
