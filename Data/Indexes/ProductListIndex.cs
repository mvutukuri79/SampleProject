using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;
using Raven.Abstractions.Indexing;
using Raven.Client.Indexes;

namespace Data.Indexes
{
    public class ProductListIndex: AbstractIndexCreationTask<Product>
    {
        public ProductListIndex()
        {
            Map = products => from product in products
                              select new
                                     {
                                            product.Id, // product id
                                            product.ProductName,
                                         product.ProductCategory//,
                                         //product.Price,
                                         //product.Description
                                     };
            //Index(x => x.ProductName, FieldIndexing.NotAnalyzed);         
        }
    }
}
