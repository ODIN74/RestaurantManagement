using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IngredientsController
        public IActionResult CategoriesIndex()
        {
            IEnumerable<MenuCategory> categories = _context.Categories;
            return View(categories);
        }

        // GET: IngredientsController/Create
        public IActionResult Create()
        {
            MenuCategory category = new MenuCategory();
            return PartialView("_CategoryCreatePartial", category);
        }

        // POST: IngredientsController/Create
        [HttpPost]
        public async Task<IActionResult> Create(MenuCategory category)
        {
            if (ModelState.IsValid)
            {
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("CategoriesIndex");
        }

        // GET: IngredientsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            MenuCategory categoryForEdit = await _context.Categories.FindAsync(id);
            return PartialView("_CategoryEditPartial", categoryForEdit);
        }

        // POST: IngredientsController/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(MenuCategory editedCategory)
        {
            MenuCategory categoryForEdit = await _context.Categories.FindAsync(editedCategory.Id);

            if (categoryForEdit != null)
            {
                categoryForEdit.Name = editedCategory.Name;

                _context.Categories.Update(categoryForEdit);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("CategoriesIndex");
        }

        // GET: IngredientsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            MenuCategory categoryForDelete = await _context.Categories.FindAsync(id);
            return PartialView("_CategoryDeletePartial", categoryForDelete);
        }

        // POST: IngredientsController/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(MenuCategory deletableCategory)
        {
            MenuCategory categoryForDelete = await _context.Categories.FindAsync(deletableCategory.Id);

            if (categoryForDelete != null)
            {
                _context.Categories.Remove(categoryForDelete);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("CategoriesIndex");
        }
    }
}
