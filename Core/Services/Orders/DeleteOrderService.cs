using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class DeleteOrderService : IDeleteOrderService
    {
        private readonly IDeleteOrderService _deleteOrderService;
        public DeleteOrderService(IDeleteOrderService deleteOrderService)
        {
            _deleteOrderService = deleteOrderService;
        }

        public void Delete(int orderId)
        {
            // Logic to delete an order
            //_deleteOrderService.Delete(orderId);
        }
    }
}
