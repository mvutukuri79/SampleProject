using BusinessEntities;
using Common;
using Core.Factories;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using Core.Services.Products;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class CreateOrderService : ICreateOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUpdateOrderService _updateOrderService;    
        private readonly IIdObjectFactory<Order> _orderFactory;

        public CreateOrderService(
            IOrderRepository orderRepository, 
            IUpdateOrderService updateOrderService,
            IIdObjectFactory<Order> objectFactory)
        {
            _orderRepository = orderRepository;
            _updateOrderService = updateOrderService;
            _orderFactory = objectFactory;
        }

        public Order Create(Guid orderId,Guid userId, Guid productId, int quantity, decimal price)
        {
            var  order = _orderFactory.Create(orderId);
            _updateOrderService.Update(order, userId,productId, quantity,price);
            _orderRepository.Save(order);
            return order;
        }
    }
}
