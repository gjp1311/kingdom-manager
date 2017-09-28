using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;

namespace KingdomManager.UI.GameScreenOptions
{
    public class StatsOption : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {
            currentScreen = new StatsScreen(game);            
            currentScreen.Draw();
        }

        public bool Match(string option)
        {
            return option == "2";
        }

        public string OptionText()
        {
            return "(2) Stats";
        }
    }
}
