using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogSite.Data;

namespace BlogSite.Controllers
{

    //----------------------------------------------BU CLASS BAKINMA AMAÇLIDIR VİEWIYLA BİRLİKTE SİLİNECEK----------------------------------------------


    public class tblCategoriesController : Controller
    {
        private readonly BlogContext _context;

        public tblCategoriesController(BlogContext context)
        {
            _context = context;
        }

        // GET: tblCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblCategory.ToListAsync());
        }

        // GET: tblCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.tblCategory
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tblCategory == null)
            {
                return NotFound();
            }

            return View(tblCategory);
        }

        // GET: tblCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: tblCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,ID")] tblCategory tblCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblCategory);
        }

        // GET: tblCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.tblCategory.FindAsync(id);
            if (tblCategory == null)
            {
                return NotFound();
            }
            return View(tblCategory);
        }

        // POST: tblCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,ID")] tblCategory tblCategory)
        {
            if (id != tblCategory.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblCategoryExists(tblCategory.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tblCategory);
        }

        // GET: tblCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCategory = await _context.tblCategory
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tblCategory == null)
            {
                return NotFound();
            }

            return View(tblCategory);
        }

        // POST: tblCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblCategory = await _context.tblCategory.FindAsync(id);
            _context.tblCategory.Remove(tblCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblCategoryExists(int id)
        {
            return _context.tblCategory.Any(e => e.ID == id);
        }
    }
}
