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
            options.Add(new StatsOption());
            options.Add(new EndTurnOption());            
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            _game.PrintHeader();
            //Menu            
            Console.WriteLine();
            Console.WriteLine("Your Actions");
            DrawOptions();
            //User Response
            Read(msg);
        }
    }
}
