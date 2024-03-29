﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resturaunt_web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Resturaunt_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult AdminHomepage()
        {
            return View();
        }

        public IActionResult AdminWelcome()
        {
            return View();
        }

        public IActionResult Reservation()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
