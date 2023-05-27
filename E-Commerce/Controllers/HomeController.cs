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
        }

        public async Task<List<Product>> GetPage(IQueryable<Product> result, int pageNo)
        {
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
            var model = new IndexVM
            {
                Categories = _context.Categories.ToList(),
                Products = _context.Products.Take(4).ToList()
            };
            return View(model);
        }

        public async Task<IActionResult> Product(int page=1)
        {
            var products = _context.Products;
            var model = await GetPage(products, page);
            return View(model);
        }

        public IActionResult ProductList(int id)
        {
            var products = _context.Products.Where(c=>c.CategoryID==id).ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult Search(string productName)
        {
            var products = _context.Products.Where(p=>p.ProductName==productName).ToList();
            return View(products);
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }

        public IActionResult ProductDetail(int? id)
        {
            var product = _context.Products.Include(x => x.Category).FirstOrDefault(p => p.ProductID == id);
            return View(product);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
