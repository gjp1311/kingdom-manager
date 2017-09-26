﻿using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class NewGameOption : IOption
    {
        public void Do(Game game)
        {            
            NewGameScreen screen = new NewGameScreen(game);
            screen.Draw();
        }

        public bool Match(string option)
        {
            return option == "1";
        }
    }
}
