using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;


namespace WebApi.Models.Orders
{
    public class OrderData: IdObjectData
    {
        public OrderData(Order order) : base(order)
        {
            OrderNumber = order.OrderNumber;
            CustomerName = order.CustomerName;
            OrderDate = order.OrderDate;
            TotalAmount = order.TotalAmount;
            //Products = order.Products.Select(p => new ProductData(p)).ToList();
        }
        public string OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        //public List<ProductData> Products { get; set; } = new List<ProductData>();
        public decimal TotalAmount { get; set; }
    }
}