using KingdomManager.Core;
using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class ElfOption : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {
            game.Player.Race = ERace.Elf;
            currentScreen = new GameScreen(game);
            currentScreen.Draw();
        }

        public bool Match(string option)
        {
            return option == "1";
        }
    }
}
