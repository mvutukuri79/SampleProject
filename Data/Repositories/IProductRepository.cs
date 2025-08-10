using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;
namespace Data.Repositories
{
    public interface  IProductRepository :IRepository<Product>
    {        
        IEnumerable<Product> GetProducts(string productCategory=null, string productName=null);
        void DeleteAll();
    }
}
