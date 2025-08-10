using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class CreateOrderService : ICreateOrderService
    {
        private readonly ICreateOrderService _createOrderService;
        //private readonly IDeleteOrderService _deleteOrderService;
        //private readonly IGetOrderService _getOrderService;
        //private readonly IUpdateOrderService _updateOrderService;

        public CreateOrderService(ICreateOrderService createOrderService
            //, IDeleteOrderService deleteOrderService, IGetOrderService getOrderService, 
            //IUpdateOrderService updateOrderService
            )
        {
            _createOrderService = createOrderService;
            //_deleteOrderService = deleteOrderService;
            //_getOrderService = getOrderService;
            //_updateOrderService = updateOrderService;
            // Constructor logic here
        }

        public void Create(Guid orderId, string customerName, DateTime orderDate,
                            List<Product> orderItems)
        {
            // Logic to create an order
            var order =  new Order
            {
                OrderId = orderId,
                CustomerName = customerName,
                OrderDate = orderDate,
                Products = orderItems
            };
        }
    }
}
