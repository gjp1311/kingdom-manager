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
        private int CurrentSeasonIndex { get; set; }
        public string CurrentSeason { get { return Seasons[CurrentSeasonIndex]; } }

        public int CurrentYear { get; private set; }

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

            CurrentYear = 0;
            CurrentSeasonIndex = 0;
        }

        public void EndTurn()
        {
            ChangeData();
        }

        private void ChangeData()
        {
            if (CurrentSeasonIndex == Seasons.Count - 1)
            {
                CurrentSeasonIndex = 0;
                CurrentYear++;
            }
            else
                CurrentSeasonIndex++;
        }

        public void PrintHeader()
        {
            Console.WriteLine($"Year: {CurrentYear} Season: {CurrentSeason}");
            Console.WriteLine(Player.Header());
        }
    }
}
