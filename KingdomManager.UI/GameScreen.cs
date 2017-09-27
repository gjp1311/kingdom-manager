using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;
using KingdomManager.Domain;
using KingdomManager.UI.InitialScreenOptions;

namespace KingdomManager.UI
{
    public class GameScreen : BaseScreen
    {
        public GameScreen(Game game) : base(game)
        {
            options.Add(new EndTurnOption());            
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            Console.WriteLine($"Year: {_game.CurrentYear} Season: {_game.CurrentSeason} - {_game.CurrentDay}");
            Console.WriteLine($"Civilization: {_game.Player.Race.ToString()} - Gold: {_game.Player.Gold} - " +
                $"Cities: {_game.Player.Cities} - Population: {_game.Player.Population}");
            //Menu            
            Console.WriteLine();
            Console.WriteLine("Your Actions");
            Console.WriteLine($@"(12)End Turn");
            //User Response
            Read(msg);
        }
    }
}
