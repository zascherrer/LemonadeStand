﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        private double money;

        public Player()
        {
            Console.WriteLine("please enter your name: ");
            name = Console.ReadLine();

            money = 20.00;
        }


    }
}