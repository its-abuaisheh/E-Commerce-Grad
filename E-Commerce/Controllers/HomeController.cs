using E_Commerce.Data;
using E_Commerce.Models;
using Ecommerce.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EcommerceContext _context;

        public HomeController(ILogger<HomeController> logger, EcommerceContext context)
        {
            _logger = logger;
            _context = context;
            ViewBag.x = "aa";
        }

        public async Task<List<Product>> GetPage(IQueryable<Product> result, int pageNo)
        {
            ViewBag.category = _context.Categories.ToList();
            const int pageSize = 5;
            decimal rowCount = await _context.Products.CountAsync();
            var pageCount = Math.Ceiling(rowCount / pageSize);
            if(pageNo > pageCount)
            {
                pageNo = 1;
            }
            pageNo = pageNo <= 0 ? 1 : pageNo;
            int skipCount = (pageNo - 1)* pageSize;
            var pageData = await result.Skip(skipCount).Take(pageSize).ToListAsync();
            ViewBag.CurrentPage = pageNo;
            ViewBag.PageCount = pageCount;
            return pageData;
        }

        public IActionResult Index()
        {
            ViewBag.category = _context.Categories.ToList();
            var model = new IndexVM
            {
                Categories = _context.Categories.ToList(),
                Products = _context.Products.ToList()
            };
            return View(model);
        }

        public async Task<IActionResult> Product(int page=1)
        {
            ViewBag.category = _context.Categories.ToList();
            var products = _context.Products;
            var model = await GetPage(products, page);
            return View(model);
        }

        public IActionResult ProductList(int id)
        {
            ViewBag.category = _context.Categories.ToList();
            var products = _context.Products.Where(c => c.CategoryID == id).ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult Search(string productName)
        {
            ViewBag.category = _context.Categories.ToList();
            var products = _context.Products.Where(p=>p.ProductName==productName).ToList();
            return View(products);
        }

        public IActionResult ShoppingCart()
        {
            ViewBag.category = _context.Categories.ToList();
            return View();
        }

        public IActionResult ProductDetail(int? id)
        {
            ViewBag.category = _context.Categories.ToList();
            var product = _context.Products.Include(x => x.Category).FirstOrDefault(p => p.ProductID == id);
            return View(product);
        }

        public IActionResult Contact()
        {
            ViewBag.category = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            ViewBag.category = _context.Categories.ToList();
            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.category = _context.Categories.ToList();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
