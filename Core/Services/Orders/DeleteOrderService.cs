using Common;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Repositories;
using BusinessEntities;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class DeleteOrderService : IDeleteOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IGetOrderService _getOrderService;
        public DeleteOrderService(IOrderRepository orderRepository, 
            IGetOrderService getOrderService)
        {
            _orderRepository = orderRepository;
            _getOrderService = getOrderService;
        }

        public void Delete(Order order)
        {           
            _orderRepository.Delete(order);
        }
    }
}
