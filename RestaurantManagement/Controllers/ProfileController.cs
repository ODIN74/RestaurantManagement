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
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ProfileController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: ProfileController
        public async Task<IActionResult> ProfileIndex(string name)
        {
            IdentityUser user = await _userManager.FindByNameAsync(name.ToUpper());
            AdditionalUserInformation info = new AdditionalUserInformation();
            UserProfileEditModel infoModel = new UserProfileEditModel();
            if (user != null)
            {
                info = await _context.AdditionalUserInformation
                    .Where(c => c.User.Id == user.Id).FirstOrDefaultAsync();
                if(info == null)
                {
                    info.id = -1;
                    info.User = user;
                }

                infoModel.Id = info.id;
                infoModel.UserId = user.Id;
                infoModel.UserName = user.UserName;
                infoModel.Email = user.Email;
                infoModel.FirstName = info.FirstName;
                infoModel.LastName = info.LastName;
                infoModel.Address = info.Address;
                infoModel.City = info.City;
                infoModel.PhoneNumber = user.PhoneNumber;
                infoModel.PostalCode = info.PostalCode;
                infoModel.AboutMe = info.AboutMe;
            }
            return View(infoModel);
        }

        // POST: ProfileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserProfileEditModel info)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByIdAsync(info.UserId);
                if (user != null)
                {
                    if (info.UserName != user.UserName || info.Email != user.Email || info.PhoneNumber != user.PhoneNumber)
                    {
                        if (info.UserName != user.UserName) user.UserName = info.UserName;
                        if (info.Email != user.Email) user.Email = info.Email;
                        if (info.PhoneNumber != user.PhoneNumber) user.PhoneNumber = info.PhoneNumber;
                        await _userManager.UpdateAsync(user);
                    }

                    if (info.Id == -1)
                    {
                        await _context.AdditionalUserInformation.AddAsync(new AdditionalUserInformation()
                        {
                            User = user,
                            FirstName = info.FirstName,
                            LastName = info.LastName,
                            Address = info.Address,
                            PostalCode = info.PostalCode,
                            City = info.City,
                            AboutMe = info.AboutMe
                        });
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        AdditionalUserInformation infoFromDb = await _context.AdditionalUserInformation
                            .Where(c => c.User.Id == user.Id).FirstOrDefaultAsync();
                        infoFromDb.AboutMe = info.AboutMe;
                        infoFromDb.Address = info.Address;
                        infoFromDb.City = info.City;
                        infoFromDb.FirstName = info.FirstName;
                        infoFromDb.LastName = info.LastName;
                        infoFromDb.PostalCode = info.PostalCode;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            return RedirectToAction("DishesIndex","Dishes");
        }
    }
}
