using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Domain
{
    public class City
    {
        public string Name { get; set; }
        public List<Building> Buildings { get; set; }
        public int Population { get; set; }
        public int Food { get; set; }

        public City()
        {
            Buildings = new List<Building>();
            Food = 10;
        }

        public void AddFood(int amount)
        {
            Food += amount;
        }

        public void RemoveFood(int amount)
        {
            if (Food - amount < 0)
                Food = 0;
            else
                Food -= amount;
        }
    }
}
