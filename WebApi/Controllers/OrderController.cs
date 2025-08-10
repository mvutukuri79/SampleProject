using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;
using Core.Services.Orders;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Models.Orders;
using Core.Services.Products;

namespace WebApi.Controllers
{
    [RoutePrefix("orders")]
    public class OrderController : BaseApiController
    {
        private readonly ICreateOrderService _createOrderService;
        private readonly IDeleteOrderService _deleteOrderService;
        private readonly IGetOrderService _getOrderService;
        private readonly IUpdateOrderService _updateOrderService;
        private readonly IGetProductService _getProductService;
        public OrderController(ICreateOrderService createOrderService,
                IDeleteOrderService deleteOrderService,
                IGetOrderService getOrderService,
                IUpdateOrderService updateOrderService,
                IGetProductService getProductService)
        {
            _createOrderService = createOrderService;
            _deleteOrderService = deleteOrderService;
            _getOrderService = getOrderService;
            _updateOrderService = updateOrderService;
            _getProductService = getProductService;
        }

        [Route("{orderId:guid}/create")]
        [HttpPost]
        public HttpResponseMessage CreateOrder(Guid orderId, [FromBody] OrderModel model)
        {
            if (!ModelState.IsValid)
            {
                var response = Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ModelState);
                return response;
            }
            if (_getOrderService.GetOrder(orderId) != null)
            {
                return AlreadyExists();
            }
            //check product id now
            var product = _getProductService.GetProduct(model.ProductId);
            if (product == null)
            {
                return DoesNotExist();
            }

            var order = _createOrderService.Create(orderId, model.UserId,
                model.ProductId, model.Quantity, model.Price);
            return Found(new OrderData(order));
        }

        [Route("{orderId:guid}/delete")]
        [HttpDelete]
        public HttpResponseMessage DeleteOrder(Guid orderId)
        {
            if (!ModelState.IsValid)
            {
                var response = Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ModelState);
                return response;
            }
            var order = _getOrderService.GetOrder(orderId);
            if (order == null)
            {
                return DoesNotExist();
            }
            _deleteOrderService.Delete(order);
            return Found();
        }

        [Route("{orderId:guid}/update")]
        [HttpPut]
        public HttpResponseMessage Update(Guid orderId, [FromBody] OrderModel model)
        {
            if (!ModelState.IsValid)
            {
                var response = Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ModelState);
                return response;
            }
            var order = _getOrderService.GetOrder(orderId);
            if (order == null)
            {
                return DoesNotExist();
            }
            _updateOrderService.Update(order, model.UserId,
                model.ProductId, model.Quantity, model.Price);
            return Found(new OrderData(order));
        }

        [Route("{orderId:guid}")]
        [HttpGet]
        public HttpResponseMessage GetOrder(Guid orderId)
        {
            var order = _getOrderService.GetOrder(orderId);
            if (order == null)
            {
                return DoesNotExist();
            }
            return Found(new OrderData(order));
        }

        [Route("list")]
        [HttpGet]
        public HttpResponseMessage GetOrders([FromBody] OrderModel model)
        {
            IEnumerable<Order> orders = _getOrderService.GetOrders(model.UserId, model.ProductId);
            if (orders == null || !orders.Any())
            {
                return DoesNotExist();
            }
            return Found(orders);
        }
    }
}