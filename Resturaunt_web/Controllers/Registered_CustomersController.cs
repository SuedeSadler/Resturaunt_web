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
    public class Registered_CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Registered_CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Registered_Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registered_Customers.ToListAsync());
        }

        // GET: Registered_Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registered_Customers = await _context.Registered_Customers
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (registered_Customers == null)
            {
                return NotFound();
            }

            return View(registered_Customers);
        }

        // GET: Registered_Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registered_Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,CustomerName,CustomerEmail,CustomerPhone,CustomerPassword")] Registered_Customers registered_Customers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registered_Customers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registered_Customers);
        }

        // GET: Registered_Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registered_Customers = await _context.Registered_Customers.FindAsync(id);
            if (registered_Customers == null)
            {
                return NotFound();
            }
            return View(registered_Customers);
        }

        // POST: Registered_Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("CustomerID,CustomerName,CustomerEmail,CustomerPhone,CustomerPassword")] Registered_Customers registered_Customers)
        {
            if (id != registered_Customers.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registered_Customers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Registered_CustomersExists(registered_Customers.CustomerID))
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
            return View(registered_Customers);
        }

        // GET: Registered_Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registered_Customers = await _context.Registered_Customers
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (registered_Customers == null)
            {
                return NotFound();
            }

            return View(registered_Customers);
        }

        // POST: Registered_Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var registered_Customers = await _context.Registered_Customers.FindAsync(id);
            _context.Registered_Customers.Remove(registered_Customers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Registered_CustomersExists(int? id)
        {
            return _context.Registered_Customers.Any(e => e.CustomerID == id);
        }
    }
}
