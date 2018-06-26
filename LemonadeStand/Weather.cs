using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        private int temperature;
        public Random random;
        public string weatherEffect;
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }

        public Weather()
        {
            random = new Random();

            SetWeather();
        }

        public void SetWeather()
        {
            SetTemperature();
            SetWeatherEffect();
        }

        private void SetTemperature()
        {
            temperature = random.Next(50, 101);
        }

        private void SetWeatherEffect()
        {
            int weatherEffectInt = random.Next(1, 7);

            switch (weatherEffectInt)
            {
                case 1:
                    weatherEffect = "Rainy";
                    break;
                case 2:
                    weatherEffect = "Foggy";
                    break;
                case 3:
                    weatherEffect = "Sunny";
                    break;
                case 4:
                    weatherEffect = "Cloudy";
                    break;
                case 5:
                    weatherEffect = "Overcast";
                    break;
                case 6:
                    weatherEffect = "Humid";
                    break;
                default:
                    weatherEffect = "Something went wrong in the Set Weather Effect function";
                    break;
            }

        }

        public void AlterWeather()
        {
            AlterTemperature();
            AlterWeatherEffect();

        }

        private void AlterTemperature()
        {
            int temperatureChange = random.Next(0, 3);

            if (temperatureChange == 0)
            {
                temperature -= 5;
            }
            else if (temperatureChange == 2)
            {
                temperature += 5;
            }
        }

        private void AlterWeatherEffect()
        {
            int effectChange = random.Next(0, 3);

            if(effectChange == 2)
            {
                SetWeatherEffect();
            }
        }

        public void DisplayWeather()
        {
            Console.WriteLine("\n\nThe weather ended up being {0} degrees and {1} today.", temperature, weatherEffect);
        }
    }
}
