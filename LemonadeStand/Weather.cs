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

            temperature = random.Next(50, 101);
        }

        public void SetWeather()
        {

        }
    }
}
