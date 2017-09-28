using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Domain.Buildings
{
    public class House : Building
    {

        public House()
        {
            Id = 2;
            Name = "House";
            Description = "Houses 5 peasants. Generates tax revenue.";
            Price = 10;
        }

        public override Building Build()
        {
            return new House();
        }

        public override void Turn(Player player)
        {
            player.City.RemoveFood(1);            
        }
    }
}
