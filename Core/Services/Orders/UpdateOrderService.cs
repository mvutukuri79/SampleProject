using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class UpdateOrderService: IUpdateOrderService
    {
        private readonly IUpdateOrderService _updateOrderService;
        public UpdateOrderService(IUpdateOrderService updateOrderService)
        {
            _updateOrderService = updateOrderService;
        }

        void IUpdateOrderService.UpdateOrder(Guid orderId, string customerName, DateTime orderDate,
                             List<Product> orderItems)
        {
            // Logic to update an order
            var order = new Order
            {
                OrderId = orderId,
                CustomerName = customerName,
                OrderDate = orderDate,
                //Products = orderItems
            };
            // Call the service to update the order
            //_updateOrderService.Update(orderId, customerName, orderDate, orderItems);
            Console.WriteLine($"Order {orderId} updated successfully.");
        }
        
    }
}
