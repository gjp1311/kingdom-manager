using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class NewGameOption : IOption
    {
        public void Do()
        {            
            NewGameScreen screen = new NewGameScreen();
            screen.Draw();
        }

        public bool Match(string option)
        {
            return option == "1";
        }
    }
}
