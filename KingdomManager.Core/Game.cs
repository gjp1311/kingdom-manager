using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Core
{
    public class Game
    {
        public Player Player { get; set; }


        public void NewGame()
        {
            Player = new Player();
        }
    }
}
