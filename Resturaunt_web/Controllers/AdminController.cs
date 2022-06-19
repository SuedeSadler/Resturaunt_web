using System;
using Microsoft.AspNetCore.Mvc;
using Resturaunt_web.Models;
using System.Data.SqlClient;
using Resturaunt_web.Services;

namespace Resturaunt_web.Controllers
{
    public class AdminController : Controller
    {
        
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(Login login)
        {
            if (login.Email == "Admin@Dynamicadmin.co.nz" && login.Password == "AdminPassword")
            {
                return View("AdminWelcome");
            }
            else
            {
                return View("LoginFailure");
            }
        }
        
    }   
}
