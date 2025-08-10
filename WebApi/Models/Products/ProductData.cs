using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;

namespace WebApi.Models.Products
{
    public class ProductData: IdObjectData
    {
        public ProductData(Product product) : base(product)
        {
            ProductName = product.ProductName;
            ProductCategory = product.ProductCategory;
            Price = product.Price;
            Description = product.Description;
            Quantity = product.Quantity;
        }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
    }
}