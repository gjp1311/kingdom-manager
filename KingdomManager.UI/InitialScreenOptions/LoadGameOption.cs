using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class LoadGameOption : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {
            currentScreen = new InitialScreen(game);
            currentScreen.Draw("Loading not implemented");
        }

        public bool Match(string option)
        {
            return option == "2";
        }

        public string OptionText()
        {
            return "(2)Load Game";
        }
    }
}
