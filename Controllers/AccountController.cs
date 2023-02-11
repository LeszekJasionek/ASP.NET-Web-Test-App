using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using web_test_app.Models;

namespace web_test_app.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UserModel> _userManager;

        public AccountController(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login userLoginData)
        {
            if(!ModelState.IsValid)
            {
                return View(userLoginData);
            }

            // logic that logging

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register userRegisterData)
        {
            if(!ModelState.IsValid)
            {
                return View(userRegisterData);
            }


            // logic for registration

            var newUser = new UserModel
            {
                Email = userRegisterData.Email,
                UserName = userRegisterData.UserName,
            };

            await _userManager.CreateAsync(newUser, userRegisterData.Password);



            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            return View();
        }

    }
}
