using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models.Users;

namespace RestaurantManagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public AdminController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: AdminController
        public ActionResult Index()
        {
            var users = new List<IdentityUser>(); //_userManager.Users.ToList();

            return View(users);
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var newUser = new UserCreateModel();

            return PartialView("_UserCreatePartial", newUser);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserCreateModel user)
        {
                var newUser = new IdentityUser()
                {
                    UserName = user.Name,
                    Email = user.Email
                };

                await _userManager.CreateAsync(newUser, user.Password);
                IdentityUser createdUser = await _userManager.FindByEmailAsync(newUser.Email);
                var newUserInfo = new AdditionalUserInformation()
                {
                    User = createdUser
                };
                await _context.AdditionalUserInformation.AddAsync(newUserInfo);
                _context.SaveChanges();

                return RedirectToAction("Index");
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
