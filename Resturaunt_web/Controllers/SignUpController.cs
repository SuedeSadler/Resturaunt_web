using Microsoft.AspNetCore.Mvc;
using Resturaunt_web.Models;
using Resturaunt_web.Services;
using System.Data.SqlClient;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Resturaunt_web.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View("Signup");
        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Reservation_Id,Name,Phone,Email,NumPeople,Booked_time")] SignUp signup)
//{
//            if (ModelState.IsValid)
//{
//                _context.Add(reservations1);
//                await _context.SaveChangesAsync();

//                int id = (int)reservations1.Reservation_Id;

//                return RedirectToAction(nameof(ResConfirmation));
//                //return RedirectToAction(nameof(Reservation));
//            }

//            return View(reservations1);
//        }

    }
}
