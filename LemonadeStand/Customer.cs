﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        private double pricePreferred;
        private int icePreferred;
        private int sugarPreferred;
        private int lemonsPreferred;
        private int thirst;
        private Random random;
        public Feedback feedback;

        public Customer(Weather weather, Player player, Recipe lemonade, Random random)
        {
            this.random = random;
            feedback = new Feedback();
            
            thirst = random.Next(0, 50);
            SetPreferences(weather);
            AdjustThirstByPreferences(lemonade);
            BuyLemonade(player, lemonade);

        }

        private void SetPreferences(Weather weather)
        {

            SetLemonPreference(weather);
            SetSugarPreference(weather);
            SetIcePreference(weather);
            SetThirst(weather);

            SetPricePreference(weather);

        }

        private void SetLemonPreference(Weather weather)
        {
            lemonsPreferred = random.Next(3, 6);

            if(weather.weatherEffect == "Rain!")
            {
                lemonsPreferred += 1;
            }
        }

        private void SetSugarPreference(Weather weather)
        {
            sugarPreferred = random.Next(4, 7);
        }

        private void SetIcePreference(Weather weather)
        {
            int firstTemperatureThreshold = 75;
            int secondTemperatureThreshold = 90;

            icePreferred = random.Next(3, 6);

            if (weather.Temperature >= firstTemperatureThreshold)
            {
                icePreferred += 1;

                if (weather.Temperature >= secondTemperatureThreshold)
                {
                    icePreferred += 1;
                }
            }
        }

        private void SetThirst(Weather weather)
        {
            thirst += weather.Temperature / 10;

            switch (weather.weatherEffect)
            {
                case "Rainy":
                    thirst -= 25;
                    break;
                case "Foggy":
                    thirst -= 15;
                    break;
                case "Sunny":
                    thirst += 15;
                    break;
                case "Cloudy":
                    thirst += 0;
                    break;
                case "Overcast":
                    thirst -= 5;
                    break;
                case "Humid":
                    thirst += 25;
                    break;
                default:
                    break;
            }
        }

        private void AdjustThirstByPreferences(Recipe lemonade)
        {
            if(lemonade.recipe.lemons.count == lemonsPreferred)
            {
                thirst += 5;
            }

            if(lemonade.recipe.sugar.count == sugarPreferred)
            {
                thirst += 5;
            }

            if(lemonade.recipe.ice.count == icePreferred)
            {
                thirst += 5;
            }
        }

        private void SetPricePreference(Weather weather)
        {
            pricePreferred = ((lemonsPreferred + sugarPreferred + icePreferred) * 2 + thirst / 2) / 100.0;
        }

        private void BuyLemonade(Player player, Recipe lemonade)
        {
            int chanceToBuy = random.Next(0, 100);
            bool willBuy;

            willBuy = EvaluatePrice(lemonade.price);

            if (chanceToBuy <= thirst)
            {
                if (willBuy && !player.soldOut)
                {
                    player.SellLemonade();
                    ConstructFeedback(lemonade);
                }
            }
        }

        private bool EvaluatePrice(double price)
        {
            int thirstThreshold = 35;
            double upperPriceThreshold = pricePreferred + 0.25;

            if (price > upperPriceThreshold)
            {
                return false;
            }
            else if (price > pricePreferred)
            {
                if (thirst > thirstThreshold)
                {
                    feedback.price = 1;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (price < pricePreferred)
            {
                thirst += Convert.ToInt32((pricePreferred - price) * 100);
                return true;
            }
            else
            {
                return true;
            }
        }

        private void ConstructFeedback(Recipe lemonade)
        {
            feedback.sourness = lemonade.recipe.lemons.count - lemonsPreferred;
            feedback.sweetness = lemonade.recipe.sugar.count - sugarPreferred;
            feedback.temperature = lemonade.recipe.ice.count - icePreferred;
        }
    }
}
