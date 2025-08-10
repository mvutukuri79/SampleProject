using Raven.Client;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Data.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly IDocumentSession _documentSession; 
        public OrderRepository(IDocumentSession documentSession)
        {   _documentSession = documentSession; 
        
        }    

        public Order GetOrder(int orderId)
        {
            //if (order == null) throw new ArgumentNullException(nameof(order));
            //_documentSession.Store(order);
            return new Order();
        }   

        public IEnumerable<Order> GetOrders(int? orderId,DateTime? orderDate)
        {
            //if (string.IsNullOrEmpty(orderId)) throw new ArgumentNullException(nameof(orderId));
            //return _documentSession.Load<Order>(orderId);
            List<Order> orders = new List<Order>();
            return orders;
        }
    }
}
