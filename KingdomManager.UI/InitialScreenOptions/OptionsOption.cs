using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class OptionsOption : IOption
    {
        public void Do()
        {            
            InitialScreen screen = new InitialScreen();
            screen.Draw("Options not implemented");
        }

        public bool Match(string option)
        {
            return option == "3";
        }
    }
}
