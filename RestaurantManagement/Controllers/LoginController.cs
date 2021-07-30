using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RestaurantManagement.Data.Users;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace RestaurantManagement.Controllers
{
    public class LoginController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginIndex(UserLoginModel model)
        {
            
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    SignInResult result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError("Error", "Invalid user email or password");
                }
            }
            return View(model);
        }
    }
}
