using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models.Products
{
    public class ProductModel
    {
        public Guid ProductId { get; set; }
        [Required(ErrorMessage = "Product name is required.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product category is required.")]
        public string ProductCategory { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Product ID is required.")]
        public int? Quantity { get; set; }
    }
}