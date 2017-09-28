using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Domain.Buildings
{
    public class Farm : Building
    {

        public Farm()
        {
            Id = 1;
            Name = "Farm";
            Description = "Houses 10 peasants. Can hold 1 food. Generates food.";
            Price = 10;
        }

        public override Building Build()
        {
            return new Farm();
        }

        public override void Turn(Player player)
        {
            player.City.RemoveFood(2);
            player.City.AddFood(3);
        }
    }
}
