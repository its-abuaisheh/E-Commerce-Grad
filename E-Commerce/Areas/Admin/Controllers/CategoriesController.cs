using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly EcommerceContext _context;

        public CategoriesController(EcommerceContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category model,IFormFile File)
        {
            if (File != null)
            {
                string imageName = Guid.NewGuid().ToString() + ".jpg";
                string filePathImage=Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\category", imageName);
                using (var stream = System.IO.File.Create(filePathImage))
                {
                    await File.CopyToAsync(stream);
                }
                model.CategoryImage = imageName;
            }
            _context.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var categories = _context.Categories.Find(id);
            return View(categories);
        }

        [HttpPost]
        public IActionResult Edit(int id,Category model, IFormFile File)
        {
            if (File != null)
            {
                string imageName = Guid.NewGuid().ToString() + ".jpg";
                string filePathImage = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\category", imageName);
                using (var stream = System.IO.File.Create(filePathImage))
                {
                     File.CopyTo(stream);
                }
                model.CategoryImage = imageName;
            }
            else
            {
                model.CategoryImage = model.CategoryImage;
            }
            _context.Update(model);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var cat = _context.Categories.Find(id);
                _context.Categories.Remove(cat);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
