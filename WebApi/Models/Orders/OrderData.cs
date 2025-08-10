using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;
using Data.Indexes;


namespace WebApi.Models.Orders
{
    public class OrderData: IdObjectData
    {
        public OrderData(Order order) : base(order)
        {
            UserId = order.UserId;
            OrderDate = order.OrderDate;
            ProductId = order.ProductId;
            Price = order.Price;
            Quantity = order.Quantity;
        }

        public Guid UserId { get; }
        public DateTime OrderDate { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}