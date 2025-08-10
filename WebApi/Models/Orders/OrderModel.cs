using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Orders
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }   

        [Required(ErrorMessage = "User ID is required.")]
        public Guid UserId { get; set; }

        //public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Product Id required.")]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }
    }
}