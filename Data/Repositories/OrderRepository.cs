using Raven.Client;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;
using Common;
using Data.Indexes;
using System.Linq;


namespace Data.Repositories
{
    [AutoRegister]
    public class OrderRepository: Repository<Order>, IOrderRepository
    {
        private readonly IDocumentSession _documentSession; 
        public OrderRepository(IDocumentSession documentSession): base(documentSession)
        {   
            _documentSession = documentSession;         
        } 

        public IEnumerable<Order> GetOrders(Guid? clientId, Guid? productId)
        {
            var query = _documentSession.Advanced.DocumentQuery<Order, OrderListIndex>();
            var whareCondition = false;
            if ( clientId != Guid.Empty)
            {
                query = query.WhereEquals("UserId", clientId.ToString());
                whareCondition = true;
            }

            if (productId != Guid.Empty)
            {
                query = query.WhereEquals("ProductId", productId.ToString());
                whareCondition = true;
            }           

            return query.ToList();            
        }
        public void DeleteAll()
        {
            base.DeleteAll<OrderListIndex>();
        }   
    }
}
