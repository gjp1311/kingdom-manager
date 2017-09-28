using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Domain.Buildings
{
    public class Market : Building
    {

        public Market()
        {
            Id = 3;
            Name = "Market";
            Description = "Needs 10 peasants. Sells food and pays peasants";
            Price = 10;
        }

        public override Building Build()
        {
            return new Market();
        }

        public override void Turn(Player player)
        {
            //player.City.RemoveFood(1);
            //player.City.AddFood(2);
        }
    }
}
