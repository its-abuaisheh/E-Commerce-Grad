using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class CartsController : Controller
    {
        private readonly EcommerceContext _context;
        private readonly UserManager<User> _userManager;

        public CartsController(EcommerceContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Cart()
        {
            ViewBag.category = _context.Categories.ToList();
            var user = await _userManager.GetUserAsync(User);
            var result = _context.ShoppingCarts.Include(p => p.Product).Where(u => u.UserId == user.Id).ToList();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(ShoppingCart shoppingCart, int quantity) 
        {
            ViewBag.category = _context.Categories.ToList();
            var product = _context.Products.FirstOrDefault(p => p.ProductID == shoppingCart.ProductID);
            var user = await _userManager.GetUserAsync(User);
            var cart = new ShoppingCart
            {
                UserId = user.Id,
                ProductID = product.ProductID,
                Quantity = shoppingCart.Quantity
            };

            var shop = _context.ShoppingCarts.FirstOrDefault(u => u.UserId == user.Id && u.ProductID == shoppingCart.ProductID);
            if(quantity <= 0)
            {
                quantity = 1;
            }
            if(shop == null)
            {
                _context.ShoppingCarts.Add(cart);
            }
            else
            {
                shop.Quantity += shoppingCart.Quantity;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveItem(int id)
        {
            ViewBag.category = _context.Categories.ToList();
            var user = await _userManager.GetUserAsync(User);
            var shop = _context.ShoppingCarts.FirstOrDefault(u => u.UserId == user.Id && u.CartID == id);
            if (shop != null)
            {
                _context.ShoppingCarts.Remove(shop);
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Cart));
        }
    }
}
