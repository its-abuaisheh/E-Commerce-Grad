using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Category ID is required")]

        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }

        public int ProductID { set; get; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
