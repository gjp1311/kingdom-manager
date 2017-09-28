using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Domain.Buildings
{
    public class Granary : Building
    {

        public Granary()
        {
            Id = 4;
            Name = "Granary";
            Description = "Needs 10 peasants. Can hold 20 food. Pays peasants.";
            Price = 10;
        }

        public override Building Build()
        {
            return new Granary();
        }

        public override void Turn(Player player)
        {
            //player.City.RemoveFood(1);
            //player.City.AddFood(2);
        }
    }
}
