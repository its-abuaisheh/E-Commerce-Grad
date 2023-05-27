using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage ="Product ID is required")]

        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product Name is required")]

        public string ProductDescreption { get; set; }
        [Required(ErrorMessage = "Product Descreption is required")]

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProductPrice { get; set; }
        [Required(ErrorMessage = "Product Price is required")]

        public string ProductImage { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

    }
}
