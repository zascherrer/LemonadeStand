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
        private Random random;
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
            int weatherEffectInt = random.Next(1, 7);

            SetTemperature();

            switch (weatherEffectInt)
            {
                case 1:
                    weatherEffect = "Rain!";
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
                    weatherEffect = "Something went wrong in the Set Weather function";
                    break;
            }

        }

        private void SetTemperature()
        {
            temperature = random.Next(50, 101);
        }
    }
}
