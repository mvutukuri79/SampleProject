using BusinessEntities;
using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Products
{
    [AutoRegister]
    public class GetProductService : IGetProductService
    {
        private readonly IProductRepository _productRepository;
        public GetProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product>();
        }

        public Product GetProduct(Guid productId)
        {
            var product = _productRepository.Get(productId);
            return product;
            //return new Product
            //{
            //    ProductId = productId,
            //    ProductName = "Sample Product",
            //    Price = 9.99m,
            //    Description = "sample product",
            //    Quantity = 100
            //};
        }

        public IEnumerable<Product> GetProducts(string productCategory = null, string productName = null)
        {
            IEnumerable<Product> products = _productRepository.GetProducts(productCategory, productName);
            return products;
        }
    }
}
