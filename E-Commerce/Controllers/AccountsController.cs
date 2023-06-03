using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class AccountsController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly EcommerceContext _context;

        public AccountsController(SignInManager<User> signInManager, UserManager<User> userManager, EcommerceContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Login()
        {
            ViewBag.category = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            ViewBag.category = _context.Categories.ToList();
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);
                if ( result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");                   
                }
                else
                {
                    return View(login);
                }
            }
            return View(login);
        }
        public IActionResult Regesters()
        {
            ViewBag.category = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Regesters(RegesterVM regester)
        {
            ViewBag.category = _context.Categories.ToList();
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    Id = regester.ID,
                    Name = regester.Name,
                    Email = regester.Email,
                    UserName = regester.Email
                };
                user.Id = Guid.NewGuid().ToString();
                var result = await _userManager.CreateAsync(user, regester.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, true);
                    return RedirectToAction("Index", "Home");
                }
                else { return View(regester); }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
