using Common;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Core.Services.Orders
{
   
    public interface ICreateOrderService
    {
         void Create(Guid orderId, string customerName, 
                DateTime orderDate, 
                List<Product> products);
    }
}
