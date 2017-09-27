using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;
using KingdomManager.Domain;
using KingdomManager.UI.InitialScreenOptions;
using KingdomManager.UI.GameScreenOptions;

namespace KingdomManager.UI
{
    public class GameScreen : BaseScreen
    {
        public GameScreen(Game game) : base(game)
        {
            options.Add(new BuildOption());
            options.Add(new EndTurnOption());            
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            Console.WriteLine($"Year: {_game.CurrentYear} Season: {_game.CurrentSeason}");
            Console.WriteLine($"Civilization: {_game.Player.Race.ToString()} - Gold: {_game.Player.Gold} - " +
                $"Population: {_game.Player.Population}");
            //Menu            
            Console.WriteLine();
            Console.WriteLine("Your Actions");
            DrawOptions();
            //User Response
            Read(msg);
        }
    }
}
