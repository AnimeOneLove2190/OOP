using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesOrderDB
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool IsCompleted { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
