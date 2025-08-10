using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BusinessEntities
{
    public class Order : IdObject
    {
        //public Guid Id { get; set; }        
        //public string OrderNumber { get; set; }
        public  Guid UserId { get; set; } //Id of the customer       
        public DateTime OrderDate { get; set; } // date of order creation
        public Guid  ProductId { get; set; }
        public int Quantity { get; set; } // quantity ordered
        public decimal Price { get; set; } // order table should have product price
        
    }
}
