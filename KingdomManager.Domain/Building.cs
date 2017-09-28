using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.Domain
{
    public abstract class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Building()
        {

        }

        //public Building(int Id, string Name, string Description, int Price)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Description = Description;
        //    this.Price = Price;
        //}
        public abstract void Turn(Player player);
        public abstract Building Build();
        //{
        //    return new Building(Id, Name, Description, Price);
        //}
    }
}
