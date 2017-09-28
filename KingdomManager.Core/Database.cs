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
            new Building(1,"Farm",
                "Houses 10 peasants. Can hold 1 food. Generates food.",
                10),
            new Building(2,"House",
                "Houses 5 peasants. Generates tax revenue.",
                5),
            new Building(3,"Market",
                "Needs 10 peasants. Generates tax revenue and sells food.",
                25),
            new Building(4,"Granary",
                "Needs 30 peasants. Can hold 30 food.",
                50)
    };



    }
}
