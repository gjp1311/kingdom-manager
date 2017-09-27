using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.GameScreenOptions
{
    public class EndTurnOption : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {

            game.ChangeData();
            currentScreen.Draw();
        }

        public bool Match(string option)
        {
            return option == "12";
        }

        public string OptionText()
        {
            return "(12) End Turn";
        }
    }
}
