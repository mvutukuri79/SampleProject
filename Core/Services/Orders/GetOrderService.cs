using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class GetOrderService: IGetOrderService
    {
        private readonly IGetOrderService _getOrderService;
        public GetOrderService(IGetOrderService getOrderService)
        {
            _getOrderService = getOrderService;
        }

        public Order GetOrder(Guid orderId)
        {
            Order order = new Order
            {
                OrderId = orderId,
                //CustomerName = customerName,
                //OrderDate = orderDate,
                //Products = orderItems
            };
            //return _getOrderService.GetOrderById(orderId);
            return order;
        }
    }
}
