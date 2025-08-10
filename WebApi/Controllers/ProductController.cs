using Core.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
//using System.Web.Mvc;
using System.Web.Http;
using WebApi.Models.Products;
using BusinessEntities;


namespace WebApi.Controllers
{
    [RoutePrefix("products")]
    public class ProductController : BaseApiController
    {
        private readonly ICreateProductService _createProductService;
        private readonly IUpdateProductService _updateProductService;
        private readonly IGetProductService _getProductService;
        private readonly IDeleteProductService _deleteProductService;

        public ProductController(
            ICreateProductService createProductService,
            IGetProductService getProductService,
            IUpdateProductService updateProductService,
            IDeleteProductService deleteProductService
            )
        {
            _createProductService = createProductService;
            _getProductService = getProductService;
            _updateProductService = updateProductService;
            _deleteProductService = deleteProductService;
        }

        [Route("{productId:guid}/create")]
        [HttpPost]
        public HttpResponseMessage CreateProduct(Guid productId, [FromBody] ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                var response = Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ModelState);
                return response;
            }

            if (_getProductService.GetProduct(productId) != null)
            {
                return AlreadyExists();
            }
            var product = _createProductService.Create(productId, model.ProductName, model.ProductCategory,
                model.Price, model.Description, model.Quantity);
            return Found(new ProductData(product));
        }

        [Route("{productId:guid}/update")]
        [HttpPut]
        public HttpResponseMessage UpdateProduct(Guid productId, [FromBody] ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                var response = Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ModelState);
                return response;
            }
            var product = _getProductService.GetProduct(productId);
            if (product == null)
            {
                return DoesNotExist();
            }
            _updateProductService.Update(product, model.ProductName, model.ProductCategory,
                model.Price, model.Description, model.Quantity);
            return Found(new ProductData(product));
        }


        [Route("{productId:guid}/delete")]
        [HttpDelete]
        public HttpResponseMessage DeleteProduct(Guid productId)
        {
            var product = _getProductService.GetProduct(productId);
            if (product == null)
            {
                return DoesNotExist();
            }
            _deleteProductService.Delete(product);
            return Found();
        }

        [Route("{productId:guid}")]
        [HttpGet]
        public HttpResponseMessage GetProduct(Guid productId)
        {
            var product = _getProductService.GetProduct(productId);
            if (product == null)
            {
                return DoesNotExist();
            }
            return Found(new ProductData(product));
        }

        [Route("list")]
        [HttpGet]
        public HttpResponseMessage GetProducts([FromBody] ProductModel model
            //string productCategory = null,
            //string productName = null
            )
        {
            var products = _getProductService
                .GetProducts(model.ProductCategory, model.ProductName)
                //.Skip(2)
                .Select(p => new ProductData(p)).ToList();

            if (products == null || !products.Any())
            {
                return DoesNotExist();
            }
            return Found(products);

        }
    }
}