using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BusinessEntities
{
    public class Order
    {       
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalAmount { get; set; }
    }
}
