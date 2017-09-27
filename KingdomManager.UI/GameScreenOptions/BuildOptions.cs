using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;

namespace KingdomManager.UI.GameScreenOptions
{
    public class BuildOptions : IOption
    {
        public void Do(Game game, BaseScreen currentScreen)
        {
            throw new NotImplementedException();
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
