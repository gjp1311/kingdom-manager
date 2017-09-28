using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Domain
{
    public class Player
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ERace Race { get; set; }
        public int Gold { get; set; }

        public City City { get; set; }

        public Player()
        {
            City = new City();
            Gold = 99999;
        }

        public string Header()
        {
            return $"Civilization: {Race.ToString()} - Gold: {Gold} - " +
                $"Population: {City.Population}";
        }
    }
}
