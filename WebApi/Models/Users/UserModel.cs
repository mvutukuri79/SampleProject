using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BusinessEntities;

namespace WebApi.Models.Users
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        public UserTypes Type { get; set; }

        [Required(ErrorMessage = "Salary amount is required.")]
        public decimal? AnnualSalary { get; set; }

        [Required(ErrorMessage="Tags are not provided")]
        public IEnumerable<string> Tags { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }
    }
}