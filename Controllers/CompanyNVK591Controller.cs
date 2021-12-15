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
    public class CompanyNVK591Controller : Controller
    {
        private readonly MvcNVK591Context _context;

        public CompanyNVK591Controller(MvcNVK591Context context)
        {
            _context = context;
        }

        // GET: CompanyNVK591
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyNVK591.ToListAsync());
        }

        // GET: CompanyNVK591/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNVK591 = await _context.CompanyNVK591
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNVK591 == null)
            {
                return NotFound();
            }

            return View(companyNVK591);
        }

        // GET: CompanyNVK591/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyNVK591/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyNVK591 companyNVK591)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNVK591);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNVK591);
        }

        // GET: CompanyNVK591/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNVK591 = await _context.CompanyNVK591.FindAsync(id);
            if (companyNVK591 == null)
            {
                return NotFound();
            }
            return View(companyNVK591);
        }

        // POST: CompanyNVK591/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyNVK591 companyNVK591)
        {
            if (id != companyNVK591.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyNVK591);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyNVK591Exists(companyNVK591.CompanyId))
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
            return View(companyNVK591);
        }

        // GET: CompanyNVK591/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNVK591 = await _context.CompanyNVK591
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNVK591 == null)
            {
                return NotFound();
            }

            return View(companyNVK591);
        }

        // POST: CompanyNVK591/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companyNVK591 = await _context.CompanyNVK591.FindAsync(id);
            _context.CompanyNVK591.Remove(companyNVK591);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyNVK591Exists(string id)
        {
            return _context.CompanyNVK591.Any(e => e.CompanyId == id);
        }
    }
}
