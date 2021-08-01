using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantManagement.Data;

namespace RestaurantManagement.Controllers
{
    public class IngredientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IngredientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IngredientsController
        public IActionResult IngredientsIndex()
        {
            IEnumerable<Ingredients> ingredients = _context.Ingredients;
            return View(ingredients);
        }

        // GET: IngredientsController/Create
        public IActionResult Create()
        {
            Ingredients ingredient = new Ingredients();
            return PartialView("_IngredientCreatePartial", ingredient);
        }

        // POST: IngredientsController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Ingredients ingredient)
        {
            if (ModelState.IsValid)
            {
                await _context.Ingredients.AddAsync(ingredient);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("IngredientsIndex");
        }

        // GET: IngredientsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Ingredients ingForEdit = await _context.Ingredients.FindAsync(id);
            return PartialView("_IngredientEditPartial", ingForEdit);
        }

        // POST: IngredientsController/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(Ingredients editedIngredient)
        {
            Ingredients ingForEdit = await _context.Ingredients.FindAsync(editedIngredient.Id);

            if (ingForEdit != null)
            {
                ingForEdit.UnitOfMeasurement = editedIngredient.UnitOfMeasurement;
                ingForEdit.Name = editedIngredient.Name;

                _context.Ingredients.Update(ingForEdit);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("IngredientsIndex");
        }

        // GET: IngredientsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Ingredients ingForDelete = await _context.Ingredients.FindAsync(id);
            return PartialView("_IngredientDeletePartial", ingForDelete);
        }

        // POST: IngredientsController/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(Ingredients deletableIngredient)
        {
            Ingredients ingForDelete = await _context.Ingredients.FindAsync(deletableIngredient.Id);

            if (ingForDelete != null)
            {
                _context.Ingredients.Remove(ingForDelete);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("IngredientsIndex");
        }
    }
}
