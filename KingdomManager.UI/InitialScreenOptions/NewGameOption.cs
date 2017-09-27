using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class NewGameOption : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {
            currentScreen = new NewGameScreen(game);
            game.NewGame();
            currentScreen.Draw();
        }

        public bool Match(string option)
        {
            return option == "1";
        }
    }
}
