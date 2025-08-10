using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using BusinessEntities;
using Core.Services.Orders;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
//using WebApi.Models.Orders;


namespace WebApi.Controllers
{
    public class OrderController : BaseApiController
    {
        private readonly ICreateOrderService _createOrderService;
        private readonly IDeleteOrderService _deleteOrderService;
        private readonly IGetOrderService _getOrderService;
        private readonly IUpdateOrderService _updateOrderService;
        public OrderController(ICreateOrderService createOrderService, 
                IDeleteOrderService deleteOrderService, 
                IGetOrderService getOrderService, 
                IUpdateOrderService updateOrderService)
        {
            _createOrderService = createOrderService;
            _deleteOrderService = deleteOrderService;
            _getOrderService = getOrderService;
            _updateOrderService = updateOrderService;
        }
        
        //[Route("{orderId:int}/create")]
        //[HttpPost]
        //public HttpResponseMessage CreateOrder(int orderId, [FromBody] OrderModel model)
        //{
        //    if (_getOrderService.get(orderId) != null)
        //    {
        //        return AlreadyExists();
        //    }
        //    var order = _createOrderService.Create(orderId, model.ProductName, model.Quantity, model.Price, model.OrderDate, model.Tags);
        //    return Found(new OrderData(order));
        //}
    }
}