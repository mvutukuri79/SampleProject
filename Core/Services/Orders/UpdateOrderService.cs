using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class UpdateOrderService: IUpdateOrderService
    {
        public void Update(Order order, Guid userId, Guid productId, 
            int quantity, decimal price)
        {
           order.UserId = userId;
            order.ProductId = productId;
            order.Quantity = quantity;
            order.Price = price;
            order.OrderDate = DateTime.UtcNow; 
        }        
    }
}
