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
    }
}
