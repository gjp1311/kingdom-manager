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
        //TODO: Implement get total number of civilians, army and slaves
        public int Population { get; set; }
        public City City { get; set; }

        public Player()
        {
            City = new City();
        }
    }
}
