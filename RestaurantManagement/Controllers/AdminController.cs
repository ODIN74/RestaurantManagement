using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models.Roles;
using RestaurantManagement.Models.Users;

namespace RestaurantManagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public AdminController(UserManager<IdentityUser> userManager, ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
        }

        // GET: AdminController
        public IActionResult IndexUsers()
        {
            var users = _userManager.Users.ToList();

            return View(users);
        }


        [HttpGet]
        public IActionResult CreateUser()
        {
            var newUser = new UserCreateModel();

            return PartialView("_UserCreatePartial", newUser);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateModel user)
        {
            if (user != null)
            {
                var newUser = new IdentityUser()
                {
                    UserName = user.Name,
                    Email = user.Email,
                    EmailConfirmed = true
                };

                IdentityResult result = await _userManager.CreateAsync(newUser, user.Password);

                if (result.Succeeded)
                {
                    IdentityUser createdUser = await _userManager.FindByEmailAsync(newUser.Email);
                    var newUserInfo = new AdditionalUserInformation()
                    {
                        User = createdUser
                    };
                    await _context.AdditionalUserInformation.AddAsync(newUserInfo);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("IndexUsers");
        }

        // GET: AdminController/EditUser/5
        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {

            IdentityUser user = await _userManager.FindByIdAsync(id);
            var userForEdit = new UserEditModel();
            if (user != null)
            {
                userForEdit.Id = user.Id;
                userForEdit.Name = user.UserName;
                userForEdit.Email = user.Email;
            }

            return PartialView("_UserEditPartial", userForEdit);
        }

        // POST: AdminController/EditUser/5
        [HttpPost]
        public async Task<IActionResult> EditUser(UserEditModel editedUser)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByIdAsync(editedUser?.Id);
                user.Email = editedUser?.Email;
                user.UserName = editedUser?.Name;

                if (editedUser?.Password != null)
                {
                    PasswordHasher<IdentityUser> _hasher = new PasswordHasher<IdentityUser>();
                    user.PasswordHash = _hasher.HashPassword(user, editedUser?.Password);
                }

                var result = await _userManager.UpdateAsync(user);
            }

            return RedirectToAction("IndexUsers");
        }

        // GET: AdminController/DeleteUser/5
        public async Task<IActionResult> DeleteUser(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);

            var deletableUser = new UserEditModel();

            if (user != null)
            {
                deletableUser.Id = user.Id;
                deletableUser.Name = user.UserName;
                return PartialView("_UserDeletePartial", deletableUser);
            }

            return RedirectToAction("IndexUsers");
        }

        // POST: AdminController/DeleteUser/5
        [HttpPost]
        public async Task<IActionResult> DeleteUser(UserEditModel model)
        {
            if (model?.Id != null)
            {
                IdentityUser user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync(user);
                }
            }

            return RedirectToAction("IndexUsers");
        }

        public IActionResult IndexRoles()
        {
            var roles = _roleManager.Roles;

            return View(roles);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            var newRole = new IdentityRole();

            return PartialView("_RoleCreatePartial", newRole);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(IdentityRole role)
        {
            if (role != null)
            {
                IdentityResult result = await _roleManager.CreateAsync(role);
            }

            return RedirectToAction("IndexRoles");
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);

            var users = new Dictionary<IdentityUser, bool>();
            if (role != null)
            {
                foreach (IdentityUser user in _userManager.Users)
                {
                    bool isInRole = await _userManager.IsInRoleAsync(user, role.NormalizedName);
                    users.Add(user,isInRole);
                }

                var dataForEditing = new RoleEditModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                    UsersInRoleStatus = users
                };

                return View(dataForEditing);
            }

            return RedirectToAction("IndexRoles");
        }
    }
}
