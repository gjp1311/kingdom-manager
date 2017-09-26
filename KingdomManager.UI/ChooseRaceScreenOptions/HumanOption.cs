using KingdomManager.Core;
using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class HumanOption : IOption
    {
        public void Do(Game game)
        {
            game.Player.Race = ERace.Human;
        }

        public bool Match(string option)
        {
            return option == "1";
        }
    }
}
