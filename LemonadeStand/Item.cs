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

        public void SpoilItem(Random random)
        {
            int itemsSpoiledCounter = 0;
            int individualItemSpoilChance;

            if (!canSpoil)
            {
                return;
            }
            else
            {
                for(int i = 0; i < count; i++)
                {
                    individualItemSpoilChance = random.Next(1, 101);

                    if(individualItemSpoilChance <= spoilageChance * 100)
                    {
                        itemsSpoiledCounter++;
                        count--;
                    }
                }

                DisplayItemsSpoiled(itemsSpoiledCounter);
            }
        }

        private void DisplayItemsSpoiled(int itemsSpoiled)
        {
            if (itemsSpoiled > 0)
            {
                if(name == "Ice Cube")
                {
                    Console.WriteLine("\n{0} of your {1}s melted.", itemsSpoiled, name);
                }
                else
                {
                    Console.WriteLine("\n{0} of your {1}s spoiled.", itemsSpoiled, name);
                }
            }
        }
    }
}
