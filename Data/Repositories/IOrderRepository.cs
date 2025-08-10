using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Data.Repositories
{
    public interface IOrderRepository
    {
         Order GetOrder(int orderId);
        IEnumerable<Order> GetOrders(int? orderId, DateTime? orderDate);
    }
}
