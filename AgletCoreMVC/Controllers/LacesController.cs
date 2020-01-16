using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgletCoreMVC.Data;
using AgletCoreMVC.Models;

namespace AgletCoreMVC.Controllers
{
    public class LacesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LacesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Laces
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lace.ToListAsync());
        }

        // GET: Laces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lace = await _context.Lace
                .FirstOrDefaultAsync(m => m.LaceID == id);
            if (lace == null)
            {
                return NotFound();
            }

            return View(lace);
        }

        // GET: Laces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Laces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaceID,Colour,Print,Brand,Length,ImageURL,Description")] Lace lace)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lace);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lace);
        }

        // GET: Laces/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lace = await _context.Lace.FindAsync(id);
            if (lace == null)
            {
                return NotFound();
            }
            return View(lace);
        }

        // POST: Laces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LaceID,Colour,Print,Brand,Length,ImageURL,Description")] Lace lace)
        {
            if (id != lace.LaceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lace);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaceExists(lace.LaceID))
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
            return View(lace);
        }

        // GET: Laces/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lace = await _context.Lace
                .FirstOrDefaultAsync(m => m.LaceID == id);
            if (lace == null)
            {
                return NotFound();
            }

            return View(lace);
        }

        // POST: Laces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lace = await _context.Lace.FindAsync(id);
            _context.Lace.Remove(lace);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaceExists(int id)
        {
            return _context.Lace.Any(e => e.LaceID == id);
        }
    }
}
