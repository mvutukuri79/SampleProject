using Raven.Client.Indexes;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;
using Raven.Abstractions.Indexing;
using System.Linq;

namespace Data.Indexes
{
    public class OrderListIndex:AbstractIndexCreationTask<Order>
    {
        public OrderListIndex()
        {
            Map = orders => from order in orders
                            select new
                                   {
                                       order.Id, // order id
                                       order.UserId, // customer id
                                       order.ProductId, // product id
                                       order.Price, // price
                                       order.Quantity, // quantity
                                       order.OrderDate // date of order creation
                            };
            Index(x => x.Id, FieldIndexing.NotAnalyzed);
            Index(x => x.UserId, FieldIndexing.NotAnalyzed);
            Index(x => x.ProductId, FieldIndexing.NotAnalyzed);
        }
    }
}
