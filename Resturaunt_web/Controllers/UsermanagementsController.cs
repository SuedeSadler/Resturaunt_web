using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resturaunt_web.Data;
using Resturaunt_web.Models;

namespace Resturaunt_web.Controllers
{
    public class UsermanagementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsermanagementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Usermanagements
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usermanagement.ToListAsync());
        }

        // GET: Usermanagements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usermanagement = await _context.Usermanagement
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usermanagement == null)
            {
                return NotFound();
            }

            return View(usermanagement);
        }

        // GET: Usermanagements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usermanagements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,Date")] Usermanagement usermanagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usermanagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usermanagement);
        }

        // GET: Usermanagements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usermanagement = await _context.Usermanagement.FindAsync(id);
            if (usermanagement == null)
            {
                return NotFound();
            }
            return View(usermanagement);
        }

        // POST: Usermanagements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,Date")] Usermanagement usermanagement)
        {
            if (id != usermanagement.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usermanagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsermanagementExists(usermanagement.ID))
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
            return View(usermanagement);
        }

        // GET: Usermanagements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usermanagement = await _context.Usermanagement
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usermanagement == null)
            {
                return NotFound();
            }

            return View(usermanagement);
        }

        // POST: Usermanagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usermanagement = await _context.Usermanagement.FindAsync(id);
            _context.Usermanagement.Remove(usermanagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsermanagementExists(int id)
        {
            return _context.Usermanagement.Any(e => e.ID == id);
        }
    }
}
