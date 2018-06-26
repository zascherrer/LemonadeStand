using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player playerOne;
        Store store;
        UserInterface ui;
        List<Day> days;
        Weather weather;

        public Game()
        {
            Console.WriteLine("Welcome to Lemonade Stand,");
            playerOne = new Player();

            store = new Store();
            ui = new UserInterface();
            days = new List<Day>();
            weather = new Weather();
        }

        public void RunGame()
        {
            while (days.Count < 7)
            {
                playerOne.soldOut = false;
                playerOne.cupsSold = 0;

                ui.DayStartMenu(playerOne, store, playerOne.recipe, weather, days);
                days.Add(new Day(weather, playerOne, playerOne.recipe));

                Console.ReadLine();

                weather.SetWeather();
            }

            ui.EndGameMenu(playerOne, days);
            Console.ReadLine();
        }
    }
}
