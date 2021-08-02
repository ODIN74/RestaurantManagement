using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        // GET: DishesController
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

        // GET: DishesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        // GET: DishesController/DishCreate
        public IActionResult DishCreate()
        {
            var model = new DishCreateModel();
            List<MenuCategory> categories = _context.Categories.ToList();
            List<MenuCategory> ingredients = _context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "DishCategoryId", "DishCategoryName");
            ViewBag.Ingredients = new SelectList(ingredients, "DishIngredientsIds", "DishIngredientsName");
            return View(model);
        }

        public IActionResult DishCreate(DishCreateModel model)
        {
            List<MenuCategory> categories = _context.Categories.ToList();
            List<MenuCategory> ingredients = _context.Categories.ToList();
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
                tempArrayForIds[tempArrayForIds.Length - 1] = -1;
                model.DishIngredientsIds = tempArrayForIds;

                string[] tempArrayForWeights = model.DishIngredientsWeights;
                Array.Resize<string>(ref tempArrayForWeights, tempArrayForWeights.Length + 1);
                tempArrayForWeights[tempArrayForWeights.Length - 1] = String.Empty;
                model.DishIngredientsWeights = tempArrayForWeights;

                return RedirectToAction("DishCreate", model); 
            }
            return RedirectToAction("DishCreate");
        }

        public IActionResult AddIngredientToDish()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddCategoryToDish(DishCreateModel model)
        {
            return PartialView("_CategorySelectorPartial");
        }

        // GET: DishesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DishesController/Edit/5
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

        // GET: DishesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DishesController/Delete/5
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
