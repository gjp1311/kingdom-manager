using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;

namespace KingdomManager.UI
{
    public class BackOption<T> : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {
            if (typeof(T) == typeof(GameScreen))
                currentScreen = new GameScreen(game);
            if (typeof(T) == typeof(BuildScreen))
                currentScreen = new BuildScreen(game);
            
            currentScreen.Draw();
        }

        public bool Match(string option)
        {
            return option == "0";
        }

        public string OptionText()
        {
            return "(0) Back";
        }
    }
}
