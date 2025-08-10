using Common;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Core.Services.Orders
{
   
    public interface ICreateOrderService
    {
         Order Create(Guid orderId,Guid UserId, Guid ProductId, int Quantity, decimal Price);
    }
}
