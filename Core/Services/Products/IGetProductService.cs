using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Core.Services.Products
{
    public interface IGetProductService
    {
      
        Product GetProduct(Guid productId);

        IEnumerable<Product> GetProducts(string productName=null,
            string productCategory = null);
    }
}
