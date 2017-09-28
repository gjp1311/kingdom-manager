using KingdomManager.Domain;
using KingdomManager.Domain.Buildings;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Core
{
    public static class Database
    {
        public static List<Building> Buildings = new List<Building>()
        {
            new Farm(),
            new House(),
            new Market(),
            new Granary()
    };



    }
}
