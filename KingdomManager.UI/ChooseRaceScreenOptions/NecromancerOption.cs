using KingdomManager.Core;
using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class NecromancerOption : IOption
    {
        public void Do(Game game)
        {
            game.Player.Race = ERace.Necromancers;
            GameScreen screen = new GameScreen(game);
            screen.Draw();
        }

        public bool Match(string option)
        {
            return option == "1";
        }
    }
}
