using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using nguyenvankhoat591.Models;

namespace nguyenvankhoat591.Controllers
{
    public class NVK0591Controller : Controller
    {
        private readonly MvcNVK591Context _context;

        public NVK0591Controller(MvcNVK591Context context)
        {
            _context = context;
        }

        // GET: NVK0591
        public async Task<IActionResult> Index()
        {
            return View(await _context.NVK0591.ToListAsync());
        }

        // GET: NVK0591/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVK0591 = await _context.NVK0591
                .FirstOrDefaultAsync(m => m.NVKId == id);
            if (nVK0591 == null)
            {
                return NotFound();
            }

            return View(nVK0591);
        }

        // GET: NVK0591/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NVK0591/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NVKId,NVKName,NVKGender")] NVK0591 nVK0591)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nVK0591);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nVK0591);
        }

        // GET: NVK0591/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVK0591 = await _context.NVK0591.FindAsync(id);
            if (nVK0591 == null)
            {
                return NotFound();
            }
            return View(nVK0591);
        }

        // POST: NVK0591/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NVKId,NVKName,NVKGender")] NVK0591 nVK0591)
        {
            if (id != nVK0591.NVKId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nVK0591);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVK0591Exists(nVK0591.NVKId))
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
            return View(nVK0591);
        }

        // GET: NVK0591/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVK0591 = await _context.NVK0591
                .FirstOrDefaultAsync(m => m.NVKId == id);
            if (nVK0591 == null)
            {
                return NotFound();
            }

            return View(nVK0591);
        }

        // POST: NVK0591/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nVK0591 = await _context.NVK0591.FindAsync(id);
            _context.NVK0591.Remove(nVK0591);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NVK0591Exists(string id)
        {
            return _context.NVK0591.Any(e => e.NVKId == id);
        }
    }
}
