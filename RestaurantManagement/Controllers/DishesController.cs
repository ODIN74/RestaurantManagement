using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models.Dishes;

namespace RestaurantManagement.Controllers
{
    public class DishesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DishesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult DishesIndex()
        {
            IEnumerable<DishesInCategories> dishesInCategories = _context.DishesInCategories;

            List<MenuCategory> categories = _context.Categories.ToList();
            categories.Sort();

            List<Dishes> dishes = _context.Dishes.ToList();

            var dataForView = new DishesViewModel()
            {
                CategoriesList = categories,
                DishesInCategories = dishesInCategories,
                DishesList = dishes
            };

            return View(dataForView);
        }


        [HttpGet]
        public IActionResult DishCreate()
        {
            var model = new DishCreateModel();
            List<MenuCategory> categories = _context.Categories.ToList();
            List<Ingredients> ingredients = _context.Ingredients.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            ViewBag.Ingredients = new SelectList(ingredients, "Id", "Name");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DishWrite(DishCreateModel model)
        {
            if (ModelState.IsValid)
            {
                Dishes newDish = new Dishes()
                {
                    Name = model.Name,
                    CookingTimeInMinutes = int.Parse(model.DishCookingTimeInMinutes),
                    IsAgreed = false,
                    IsRequiresPreparation = model.IsRequiresPreparation,
                };
                await _context.Dishes.AddAsync(newDish);
                await _context.SaveChangesAsync();

                MenuCategory category = await _context.Categories.FindAsync(model.DishCategoryId);

                if (category != null)
                {
                    await _context.DishesInCategories.AddAsync(new DishesInCategories()
                    {
                        Category = category,
                        Dish = newDish
                    });
                    await _context.SaveChangesAsync();
                }

                for (int i = 0; i < model.DishIngredientsIds.Length; i++)
                {
                    Ingredients currentIngredient = await _context.Ingredients.FindAsync(model.DishIngredientsIds[i]);
                    if (currentIngredient != null)
                    {
                        await _context.IngredientsWeights.AddAsync(new IngredientsWeights()
                        {
                            Ingredient = currentIngredient,
                            Dish = newDish,
                            Weight = float.Parse(model.DishIngredientsWeights[i])
                        });
                        await _context.SaveChangesAsync();
                    }
                }
            }
            return RedirectToAction("DishesIndex");
        }

        public IActionResult DishCreateWithIngredients(DishCreateModel model)
        {
            List<MenuCategory> categories = _context.Categories.ToList();
            List<Ingredients> ingredients = _context.Ingredients.ToList();
            model.Ingredients = _context.Ingredients.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            ViewBag.Ingredients = new SelectList(ingredients, "Id", "Name");
            return View(model);
        }

        // POST: DishesController/DishCreate
        [HttpPost]
        public IActionResult DishCreateHelper(DishCreateModel model)
        {
            if (model != null)
            {
                int[] tempArrayForIds = model.DishIngredientsIds;
                Array.Resize<int>(ref tempArrayForIds, tempArrayForIds.Length + 1);
                tempArrayForIds[^1] = _context.Ingredients.FirstOrDefault().Id;
                model.DishIngredientsIds = tempArrayForIds;

                string[] tempArrayForWeights = model.DishIngredientsWeights;
                Array.Resize<string>(ref tempArrayForWeights, tempArrayForWeights.Length + 1);
                tempArrayForWeights[^1] = "0";
                model.DishIngredientsWeights = tempArrayForWeights;

                return RedirectToAction("DishCreateWithIngredients", model); 
            }
            return RedirectToAction("DishCreate");
        }
    }
}
