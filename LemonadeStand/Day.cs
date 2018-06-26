using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public Weather weather;
        List<Customer> customers;
        Random random;
        Feedback feedbackCollected;

        public Day(Weather weather, Player player, Recipe lemonade)
        {
            this.weather = weather;
            customers = new List<Customer>();
            random = new Random();
            feedbackCollected = new Feedback();

            AddCustomers(player, lemonade);
            weather.DisplayWeather();
            DisplayProfits(player, lemonade);
            CollectFeedback();
            DisplayFeedback();
        }

        private void AddCustomers(Player player, Recipe lemonade)
        {
            int howManyCustomers = random.Next(75, 126);

            for (int i = 0; i < howManyCustomers; i++)
            {
                customers.Add(new Customer(weather, player, lemonade, weather.random));
            }
        }

        private void DisplayProfits(Player player, Recipe lemonade)
        {
            Console.WriteLine("\n\nYou sold {0} cups for a total of ${1}! \n\n", player.cupsSold, String.Format("{0:0.00}", lemonade.price * player.cupsSold));
            Console.WriteLine("After expenses, you made a total of ${0} today. Your total profit so far is ${1}. \n\n",
                String.Format("{0:0.00}", player.money - player.todaysStartingMoney), String.Format("{0:0.00}", player.money - 20));
        }

        private void CollectFeedback()
        {
            for(int i = 0; i < customers.Count; i++)
            {
                feedbackCollected.sourness += customers[i].feedback.sourness;
                feedbackCollected.sweetness += customers[i].feedback.sweetness;
                feedbackCollected.temperature += customers[i].feedback.temperature;
                feedbackCollected.price += customers[i].feedback.price;
            }
        }


        private void DisplayFeedback()
        {
            if(feedbackCollected.sourness < -10)
            {
                Console.WriteLine("The customers thought the lemonade wasn't sour enough!");
            }
            else if(feedbackCollected.sourness > 10)
            {
                Console.WriteLine("The customers thought the lemonade was too sour!");
            }
            else
            {
                Console.WriteLine("The sourness was just about right.");
            }

            if(feedbackCollected.sweetness < -10)
            {
                Console.WriteLine("The customers thought the lemonade wasn't sweet enough!");
            }
            else if(feedbackCollected.sweetness > 10)
            {
                Console.WriteLine("The customers thought the lemonade was too sweet!");
            }
            else
            {
                Console.WriteLine("The sweetness was just about right.");
            }

            if(feedbackCollected.temperature < -10)
            {
                Console.WriteLine("The customers thought the lemonade wasn't cold enough!");
            }
            else if(feedbackCollected.temperature > 10)
            {
                Console.WriteLine("The customers thought the lemonade was too cold!");
            }
            else
            {
                Console.WriteLine("The amount of ice in the lemonade was just about right.");
            }

            if(feedbackCollected.price > 10)
            {
                Console.WriteLine("The customers thought the lemonade was too pricy!");
            }
            else
            {
                Console.WriteLine("The customers thought the lemonade was fairly priced... though they wouldn't tell you if it was cheaper than they expected.");
            }
        }

    }
}
