using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Feedback
    {
        // Each of these will be set to -1 if there wasn't enough of it, 0 if it was just right and 1 if there was too much of it
        // This will be accomplished by recipe.item.count - customerItemPreference
        public int sourness; 
        public int sweetness;
        public int temperature;
        public int price;

        public Feedback()
        {

        }

    }
}
