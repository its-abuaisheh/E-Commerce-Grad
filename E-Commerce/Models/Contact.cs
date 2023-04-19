using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Contact ID is required")]

        [EmailAddress]
        public string? UserEmail { get; set; }
        [EmailAddress(ErrorMessage = "User Email is required")]

        public string? Name { get; set; }
        [Required(ErrorMessage = "Name is required")]

        public string? Subject { get; set; }
        [Required(ErrorMessage = "Subject is required")]
        public string? Message { get; set; }
        
    }
}
