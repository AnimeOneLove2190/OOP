using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesOrderDB
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
