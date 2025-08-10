using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Core.Services.Products
{
    public interface IUpdateProductService
    {
        void Update(Product product, string productName, string productCategory,
            decimal price, string description, 
                             int? quantity);
    }
}
