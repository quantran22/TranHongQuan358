using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoDotNetMVC.Models;

namespace TranHongQuan358.Controllers
{
    public class UniversityTHQ358sController : Controller
    {
        private readonly BaiTapDBContext _context;

        public UniversityTHQ358sController(BaiTapDBContext context)
        {
            _context = context;
        }

        // GET: UniversityTHQ358s
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityTHQ358.ToListAsync());
        }

        // GET: UniversityTHQ358s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTHQ358 = await _context.UniversityTHQ358
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityTHQ358 == null)
            {
                return NotFound();
            }

            return View(universityTHQ358);
        }

        // GET: UniversityTHQ358s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityTHQ358s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityTHQ358 universityTHQ358)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityTHQ358);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityTHQ358);
        }

        // GET: UniversityTHQ358s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTHQ358 = await _context.UniversityTHQ358.FindAsync(id);
            if (universityTHQ358 == null)
            {
                return NotFound();
            }
            return View(universityTHQ358);
        }

        // POST: UniversityTHQ358s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityTHQ358 universityTHQ358)
        {
            if (id != universityTHQ358.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityTHQ358);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityTHQ358Exists(universityTHQ358.UniversityId))
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
            return View(universityTHQ358);
        }

        // GET: UniversityTHQ358s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTHQ358 = await _context.UniversityTHQ358
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityTHQ358 == null)
            {
                return NotFound();
            }

            return View(universityTHQ358);
        }

        // POST: UniversityTHQ358s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityTHQ358 = await _context.UniversityTHQ358.FindAsync(id);
            _context.UniversityTHQ358.Remove(universityTHQ358);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityTHQ358Exists(string id)
        {
            return _context.UniversityTHQ358.Any(e => e.UniversityId == id);
        }
    }
}
