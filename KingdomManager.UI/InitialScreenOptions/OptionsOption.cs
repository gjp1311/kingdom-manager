using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class OptionsOption : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {
            currentScreen = new InitialScreen(game);
            currentScreen.Draw("Options not implemented");
        }

        public bool Match(string option)
        {
            return option == "3";
        }
    }
}
