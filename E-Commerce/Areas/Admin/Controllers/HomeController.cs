using E_Commerce.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly EcommerceContext _context;

        public HomeController(EcommerceContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowMessage()
        {
            var message = _context.Contacts.ToList();
            return View(message);
        }
    }
}
