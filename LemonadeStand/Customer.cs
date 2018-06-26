using System;
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

        public Customer(Weather weather)
        {
            random = new Random();
            
            thirst = random.Next(0, 51);
            SetPreferences(weather);


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
            switch (weather.weatherEffect)
            {
                case "Rain!":
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

        private void SetPricePreference(Weather weather)
        {
            pricePreferred = ((lemonsPreferred + sugarPreferred + icePreferred) * 2 + thirst / 2) / 100.0;
        }

        private void BuyLemonade()
        {

        }
    }
}
