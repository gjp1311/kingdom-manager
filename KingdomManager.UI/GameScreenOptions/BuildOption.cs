using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;

namespace KingdomManager.UI.GameScreenOptions
{
    public class BuildOption : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {
            currentScreen = new BuildScreen(game);            
            currentScreen.Draw();
        }

        public bool Match(string option)
        {
            return option == "1";
        }

        public string OptionText()
        {
            return "(1) Build";
        }
    }
}
