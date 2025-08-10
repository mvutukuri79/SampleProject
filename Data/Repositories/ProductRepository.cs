using BusinessEntities;
using Common;
using Raven.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Indexes;
using System.Net.Http;
using System.Linq;

namespace Data.Repositories
{
    [AutoRegister]
    public class ProductRepository: Repository<Product>, IProductRepository
    {
        private readonly IDocumentSession _documentSession;
        public ProductRepository(IDocumentSession documentSession) : base(documentSession)
        {
            _documentSession = documentSession;
        }

        public IEnumerable<Product> GetProducts(string productCategory, string productName) 
        {
            var query = _documentSession.Advanced.DocumentQuery<Product, ProductListIndex>();
            var whareCondition = false;
            if (!string.IsNullOrEmpty(productName))
            {
                query = query.WhereEquals("ProductName", productName);
                whareCondition = true;
            }

            if (!string.IsNullOrEmpty(productCategory))
            {
                if (whareCondition)
                {
                    query = query.AndAlso();
                }
                else
                {
                    whareCondition = true;
                }
                query = query.WhereEquals("ProductCategory", productCategory);
            }

            return query.ToList();
        }
        public void DeleteAll()
        {
            base.DeleteAll<ProductListIndex>();
        }
    }
}
