using E_Commerce.Models;
using System.Collections.Generic;

namespace Ecommerce.ViewModel
{
    public class IndexVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
