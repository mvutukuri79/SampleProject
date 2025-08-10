using BusinessEntities;
using Common;
using Core.Factories;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
namespace Core.Services.Products
{
    [AutoRegister]
    public class CreateProductService:ICreateProductService 
    {
        private readonly IProductRepository _productRepository;
        private readonly IIdObjectFactory<Product> _productFactory;
        private readonly IUpdateProductService _updateProductService;
        public CreateProductService(
            IIdObjectFactory<Product> productFactory,
            IProductRepository productRepository,
            IUpdateProductService updateProductService)
        {
            _productFactory = productFactory;
            _productRepository = productRepository;
            _updateProductService = updateProductService;
        }

        public Product Create(Guid productId, string productName, 
            string productCategory, 
            decimal price, string description, int? quantity)
        {
            var product = _productFactory.Create(productId);
            _updateProductService.Update(product, productName,
                productCategory, price,description, quantity);
            _productRepository.Save(product);
            return product;
        }
    }
}
