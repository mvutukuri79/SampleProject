using BusinessEntities;
using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class GetOrderService : IGetOrderService
    {
        
        private readonly IOrderRepository _orderRepository;
        public GetOrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order GetOrder(Guid orderId)
        {
            var order = _orderRepository.Get(orderId);
            return order;
        }

        public IEnumerable<Order> GetOrders(Guid? userId, Guid? productId)
        {
            IEnumerable<Order> orders = _orderRepository.GetOrders(userId, productId);
            return orders;
        }
    }
}
