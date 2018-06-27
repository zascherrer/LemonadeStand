using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player[] players;
        Store store;
        UserInterface ui;
        List<Day> days;
        Weather weather;
        int daysUntilGameOver;
        int dayCounter;

        public Game()
        {
            InstantiatePlayers();

            store = new Store();
            ui = new UserInterface();
            days = new List<Day>();
            weather = new Weather();

            dayCounter = 0;
            daysUntilGameOver = 7;
            daysUntilGameOver = RuntimeSelection();
            RunGame();
        }

        private void InstantiatePlayers()
        {
            int userInput = 1;

            Console.WriteLine("\nHow many players would you like to play with? \n");
            try
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e.Message);
                Console.ReadLine();
                InstantiatePlayers();
            }

            players = new Player[userInput];

            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine("Welcome to Lemonade Stand player {0},", i + 1);
                players[i] = new Player();
            }
        }

        private int RuntimeSelection()
        {
            Console.WriteLine("\n\nHow many days would you like to play for?");
            try
            {
                daysUntilGameOver = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }

            return daysUntilGameOver;
        }

        private void RunGame()
        {
            while (dayCounter < daysUntilGameOver)
            {
                dayCounter++;

                for (int i = 0; i < players.Length; i++)
                {
                    PlayerDayPreparation(players[i]);
                }

                weather.AlterWeather();

                for (int i = 0; i < players.Length; i++)
                {
                    Console.Clear();
                    PlayerDay(players[i]);
                }

                weather.SetWeather();
            }

            Console.Clear();
            Console.WriteLine("Game over!\n\n");
            for (int i = 0; i < players.Length; i++)
            {
                ui.EndGameMenu(players[i], dayCounter);
            }
            Console.ReadLine();
        }

        private void PlayerDayPreparation(Player player)
        {
            ui.DayStartMenu(player, store, player.recipe, weather, dayCounter);
        }

        private void PlayerDay(Player player)
        {
            player.soldOut = false;
            player.cupsSold = 0;

            days.Add(new Day(weather, player, player.recipe));
            player.inventory.SpoilInventory(weather.random);

            Console.ReadLine();

            player.todaysStartingMoney = player.money;
        }
    }
}
