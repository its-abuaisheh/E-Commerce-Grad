using System.ComponentModel.DataAnnotations;

namespace E_Commerce.ViewModel
{
    public class RegesterVM
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }

    }
}
