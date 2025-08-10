using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Core.Services.Orders
{
    public interface IUpdateOrderService
    {
        void UpdateOrder(Guid orderId, string customerName, DateTime orderDate,
                             List<Product> orderItems);
    }
}
