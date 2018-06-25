using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        private Inventory recipe;

        public Recipe()
        {
            recipe = new Inventory();

            recipe.cups.count = 1;
            recipe.lemons.count = 4;
            recipe.sugar.count = 4;
            recipe.ice.count = 4;
        }

        private void DisplayRecipe()
        {
            Console.WriteLine(
                "Lemons per pitcher: {0} \n" +
                "Cups of Sugar per pitcher: {1} \n" +
                "Ice cubes per cup: {2} \n",
                recipe.lemons.count, recipe.sugar.count, recipe.ice.count);
        }
    }
}
