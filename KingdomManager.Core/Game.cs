using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Core
{
    public class Game
    {
        public Player Player { get; set; }
        public List<string> Seasons { get; set; }
        public string CurrentSeason { get; set; }
        public int CurrentDay { get; set; }
        private const int LastDay = 30;

        public void NewGame()
        {
            Player = new Player();
            Seasons = new List<string>()
            {
                "Spring",
                "Summer",
                "Autumn",
                "Winter"
            };
            CurrentSeason = Seasons[0];
            CurrentDay = 1;
        }
    }
}
