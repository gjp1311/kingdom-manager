﻿using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;
using KingdomManager.Domain;

namespace KingdomManager.UI
{
    public class GameScreen : BaseScreen
    {
        public GameScreen(Game game) : base(game)
        {
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            //TODO: Implement Month/Year Cycle to show on header
            Console.WriteLine($"Civilization: {_game.Player.Race.ToString()} - Gold: {_game.Player.Gold} - " +
                $"Cities: {_game.Player.Cities} - Population: {_game.Player.Population}");
            //User Response
            Read(msg);
        }
    }
}