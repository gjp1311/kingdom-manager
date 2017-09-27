using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Domain
{
    public class City
    {
        public string Name { get; set; }
        public List<Building> Buildings { get; set; }

        public City()
        {
            Buildings = new List<Building>();
        }
    }
}
