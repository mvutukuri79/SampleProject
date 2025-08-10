using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Data.Repositories
{
    public interface IOrderRepository: IRepository<Order>
    {
        IEnumerable<Order> GetOrders(Guid? userId, Guid? productId);
        void DeleteAll();
    }
}
