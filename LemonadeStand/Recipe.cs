using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public Inventory recipe;
        public int priceInCents;
        public double price;

        public Recipe()
        {
            recipe = new Inventory();

            recipe.cups.count = 1;
            recipe.lemons.count = 4;
            recipe.sugar.count = 4;
            recipe.ice.count = 4;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\n\n" +
                "Lemons per pitcher: {0} \n" +
                "Cups of Sugar per pitcher: {1} \n" +
                "Ice cubes per cup: {2} \n" +
                "You are selling it for: ${3} per cup \n",
                recipe.lemons.count, recipe.sugar.count, recipe.ice.count, price);
            Console.ReadLine();
        }

        public void ChangeRecipe()
        {
            Console.WriteLine("\n\nHow many lemons would you like to use? Enter a whole number:\n");
            recipe.lemons.count = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nHow much sugar would you like to use? Enter a whole number:\n");
            recipe.sugar.count = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nHow many ice cubes would you like to use? Enter a whole number:\n");
            recipe.ice.count = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nThis is your current recipe: \n");
            DisplayRecipe();
        }

        public void ChangePrice()
        {
            Console.WriteLine("\n\nWhat would you like to change the price to, in cents?");
            priceInCents = int.Parse(Console.ReadLine());
            price = priceInCents / 100.0;

            Console.WriteLine("\n\nYour current recipe and price is: \n");
            DisplayRecipe();
        }
    }
}
