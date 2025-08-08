using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

    }
}
