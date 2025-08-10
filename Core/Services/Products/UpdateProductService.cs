using Common;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Core.Services.Products
{
    [AutoRegister]
    public class UpdateProductService: IUpdateProductService
    {
        //private readonly IUpdateProductService _updateProductService;        
        //public UpdateProductService(IUpdateProductService updateProductService)
        //{
        //    _updateProductService = updateProductService;
            
        //}
        public void Update(Product product, string productName, string productCategory,
            decimal price, string description,
                             int? stockQuantity)
        {
            product.ProductName = productName;
            product.ProductCategory = productCategory;
            product.Price = price;
            product.Description = description;
            if (stockQuantity.HasValue)
            {
                product.Quantity = stockQuantity.Value;
            }
        }
    }
}
