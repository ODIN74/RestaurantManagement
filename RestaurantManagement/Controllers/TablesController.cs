using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Controllers
{
    public class TablesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TablesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IngredientsController
        public IActionResult TablesIndex()
        {
            IEnumerable<Tables> tables = _context.Tables;
            return View(tables);
        }

        // GET: IngredientsController/Create
        public IActionResult Create()
        {
            Tables table = new Tables();
            return PartialView("_TableCreatePartial", table);
        }

        // POST: IngredientsController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Tables table)
        {
            if (ModelState.IsValid)
            {
                await _context.Tables.AddAsync(table);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("TablesIndex");
        }

        // GET: IngredientsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Tables tableForEdit = await _context.Tables.FindAsync(id);
            return PartialView("_TableEditPartial", tableForEdit);
        }

        // POST: IngredientsController/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(Tables editedTable)
        {
            Tables tableForEdit = await _context.Tables.FindAsync(editedTable.Id);

            if (tableForEdit != null)
            {
                tableForEdit.Name = editedTable.Name;

                _context.Tables.Update(tableForEdit);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("TablesIndex");
        }

        // GET: IngredientsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Tables tableForDelete = await _context.Tables.FindAsync(id);
            return PartialView("_TableDeletePartial", tableForDelete);
        }

        // POST: IngredientsController/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(Ingredients deletableTable)
        {
            Tables tableForDelete = await _context.Tables.FindAsync(deletableTable.Id);

            if (tableForDelete != null)
            {
                _context.Tables.Remove(tableForDelete);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("TablesIndex");
        }
    }
}
