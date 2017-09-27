using KingdomManager.Core;
using KingdomManager.UI.BuildOptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public class BuildScreen : BaseScreen
    {
        public BuildScreen(Game game) : base(game)
        {
            options.Add(new HovelsOption());
            options.Add(new HouseOption());
            options.Add(new BackOption<GameScreen>());
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            Console.WriteLine($"Year: {_game.CurrentYear} Season: {_game.CurrentSeason}");
            Console.WriteLine($"Civilization: {_game.Player.Race.ToString()} - Gold: {_game.Player.Gold} - " +
                $"Population: {_game.Player.Population}");
            //Menu            
            Console.WriteLine();
            Console.WriteLine("*Build Menu*");
            DrawOptions();
            //User Response
            Read(msg);
        }
    }
}
