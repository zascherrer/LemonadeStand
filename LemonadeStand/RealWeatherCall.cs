using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace LemonadeStand
{
    class RealWeatherCall
    {


        public static async Task<int[]> GetRealWeather()
        {
            int[] results = new int[3];

            string apiUrl = "http://api.openweathermap.org/data/2.5/weather?q=Milwaukee";
            string apiKey = "0f0d050c4f329f52e288164ef8371450";

            using(HttpClient client = new HttpClient())
            {
                string repUrl = apiUrl + "&APPID=" + apiKey;

                HttpResponseMessage response = await client.GetAsync(repUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    RealWeather.RootObject rootResult = JsonConvert.DeserializeObject<RealWeather.RootObject>(result);

                    results[0] = rootResult.clouds.all;
                    results[1] = Convert.ToInt32(rootResult.main.temp);
                    results[2] = rootResult.main.humidity;
                    return results;
                }
                else
                {
                    return results;
                }
            }

        }


    }
}
