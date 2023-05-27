using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
        [Range(1,int.MaxValue, ErrorMessage = "Quantity must be greater than or equal 1")]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
