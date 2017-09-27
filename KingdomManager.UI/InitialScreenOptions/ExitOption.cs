using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class ExitOption : IOption
    {
        public void Do(Game game,BaseScreen currentScreen)
        {
            Environment.Exit(1);
        }

        public bool Match(string option)
        {
            return option == "4";
        }

        public string OptionText()
        {
            return "(4)Exit";
        }
    }
}
