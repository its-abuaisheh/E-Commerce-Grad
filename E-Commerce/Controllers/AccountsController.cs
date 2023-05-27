using E_Commerce.Models;
using E_Commerce.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class AccountsController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountsController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Regesters(RegesterVM regester)
        {
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
