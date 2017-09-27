using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Core
{
    public static class Database
    {
        public static List<Building> Buildings = new List<Building>()
        {
            new Building(1,"Hovel",
                "Home for the poorest peasants.",
                1),
            new Building(2,"House",
                "A better home for your peasants.",
                5)
    };



}
}
