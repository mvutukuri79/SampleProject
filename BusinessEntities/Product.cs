using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities
{
    public class Product: IdObject
    {
        //public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }        
        public int? Quantity{ get; set; }

    }
}
