using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Products
{
    public interface ICreateProductService
    {
        Product Create(Guid productId, string productName, string productCategory,
                            decimal price, string description,int? quantity);
    }
}
