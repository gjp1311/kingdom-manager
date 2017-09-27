using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public class BuildScreen : BaseScreen
    {
        public BuildScreen(Game game) : base(game)
        {
            //options.Add(new EndTurnOption());
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            Console.WriteLine($"Year: {_game.CurrentYear} Season: {_game.CurrentSeason} - {_game.CurrentDay}");
            Console.WriteLine($"Civilization: {_game.Player.Race.ToString()} - Gold: {_game.Player.Gold} - " +
                $"Cities: {_game.Player.Cities} - Population: {_game.Player.Population}");
            //Menu            
            Console.WriteLine();
            Console.WriteLine("Build ");
            Console.WriteLine($@"(1)");
            //User Response
            Read(msg);
        }
    }
}
