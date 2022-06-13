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
    public class Reservations1Controller : Controller
    {
        private readonly ApplicationDbContext _context;
     

        public Reservations1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reservations1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservations1.ToListAsync());
        }

        public IActionResult Reservation()
        {
           
            return View();
        }

        public async Task<IActionResult> Emailconfirmation(int? id)
        {

            id = _context.Reservations1.Max(x => x.Reservation_Id);



            var reservations1 = await _context.Reservations1.FindAsync(id);

            if (reservations1 == null)
            {
                return NotFound();
            }
            return View(reservations1);
        }
        public async Task<IActionResult> ResConfirmation(int? id)
        {
           
               
            id = _context.Reservations1.Max(x => x.Reservation_Id);
        

            
            var reservations1 = await _context.Reservations1.FindAsync(id);
            
            if (reservations1 == null)
            {
                return NotFound();
            }
            return View(reservations1);
        }

        // GET: Reservations1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var reservations1 = await _context.Reservations1
                .FirstOrDefaultAsync(m => m.Reservation_Id == id);
            if (reservations1 == null)
            {
                return NotFound();
            }

            return View(reservations1);
        }

        // GET: Reservations1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reservations1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Reservation_Id,Name,Phone,Email,NumPeople,Booked_time")] Reservations1 reservations1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservations1);
                await _context.SaveChangesAsync();

                int id = (int)reservations1.Reservation_Id;
                
                return RedirectToAction(nameof(ResConfirmation));
                //return RedirectToAction(nameof(Reservation));
            }
            
            return View(reservations1);
        }
     

        // GET: Reservations1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations1 = await _context.Reservations1.FindAsync(id);
            if (reservations1 == null)
            {
                return NotFound();
            }
            return View(reservations1);
        }

        // POST: Reservations1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Reservation_Id,Name,Phone,Email,NumPeople,Booked_time")] Reservations1 reservations1)
        {
            if (id != reservations1.Reservation_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservations1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Reservations1Exists(reservations1.Reservation_Id))
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
            return View(reservations1);
        }

        // GET: Reservations1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations1 = await _context.Reservations1
                .FirstOrDefaultAsync(m => m.Reservation_Id == id);
            if (reservations1 == null)
            {
                return NotFound();
            }

            return View(reservations1);
        }

        // POST: Reservations1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var reservations1 = await _context.Reservations1.FindAsync(id);
            _context.Reservations1.Remove(reservations1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Reservations1Exists(int? id)
        {
            return _context.Reservations1.Any(e => e.Reservation_Id == id);
        }
    }
}
