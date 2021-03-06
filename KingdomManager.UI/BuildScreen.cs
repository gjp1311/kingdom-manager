﻿using KingdomManager.Core;
using KingdomManager.UI.BuildOptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KingdomManager.UI
{
    public class BuildScreen : BaseScreen
    {
        public BuildScreen(Game game) : base(game)
        {
            options.Add(new FarmOption());
            options.Add(new HouseOption());
            options.Add(new MarketOption());
            options.Add(new GranaryOption());
            options.Add(new BackOption<GameScreen>());
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            _game.PrintHeader();
            Console.WriteLine("Current Buildings :");
            Database.Buildings.ForEach(q =>
            {                
                var count = _game.Player.City.Buildings.Count(b => b.Id == q.Id);
                if (count > 0)
                    Console.WriteLine($"{q.Name} - {count}");
            });
            Console.WriteLine();
            //Menu            
            Console.WriteLine();
            Console.WriteLine("*Build Menu*");
            DrawOptions();
            //User Response
            Read(msg);
        }
    }
}
