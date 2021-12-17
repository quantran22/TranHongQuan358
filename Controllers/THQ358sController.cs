using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranHongQuan358.Models;

namespace TranHongQuan358.Controllers
{
    public class THQ358sController : Controller
    {
        private readonly BaiTapDBContext _context;

        public THQ358sController(BaiTapDBContext context)
        {
            _context = context;
        }

        // GET: THQ358s
        public async Task<IActionResult> Index()
        {
            return View(await _context.THQ358.ToListAsync());
        }

        // GET: THQ358s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tHQ358 = await _context.THQ358
                .FirstOrDefaultAsync(m => m.THQId == id);
            if (tHQ358 == null)
            {
                return NotFound();
            }

            return View(tHQ358);
        }

        // GET: THQ358s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: THQ358s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("THQId,THQName,THQGender")] THQ358 tHQ358)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tHQ358);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tHQ358);
        }

        // GET: THQ358s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tHQ358 = await _context.THQ358.FindAsync(id);
            if (tHQ358 == null)
            {
                return NotFound();
            }
            return View(tHQ358);
        }

        // POST: THQ358s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("THQId,THQName,THQGender")] THQ358 tHQ358)
        {
            if (id != tHQ358.THQId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tHQ358);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!THQ358Exists(tHQ358.THQId))
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
            return View(tHQ358);
        }

        // GET: THQ358s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tHQ358 = await _context.THQ358
                .FirstOrDefaultAsync(m => m.THQId == id);
            if (tHQ358 == null)
            {
                return NotFound();
            }

            return View(tHQ358);
        }

        // POST: THQ358s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tHQ358 = await _context.THQ358.FindAsync(id);
            _context.THQ358.Remove(tHQ358);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool THQ358Exists(string id)
        {
            return _context.THQ358.Any(e => e.THQId == id);
        }
    }
}
