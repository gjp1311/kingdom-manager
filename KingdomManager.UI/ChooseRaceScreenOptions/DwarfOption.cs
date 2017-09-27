using KingdomManager.Core;
using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class DwarfOption : IOption
    {
        public void Do(Game game)
        {
            game.Player.Race = ERace.Dwarf;
            GameScreen screen = new GameScreen(game);
            screen.Draw();
        }

        public bool Match(string option)
        {
            return option == "1";
        }
    }
}
