using System;
using Microsoft.AspNetCore.Mvc;
using Resturaunt_web.Models;
using System.Data.SqlClient;
using Resturaunt_web.Services;

namespace Resturaunt_web.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(Login login)
        {
            //return "Results: Email = "+login.Email + " Password = " +login.Password;
            SecurityService securityService = new SecurityService();
            Boolean success = securityService.Authenticate(login);

            if (success)
            {
                return View("LoginSuccess", login);
            }
            else
            {
                return View("LoginFailure");
            }
        }
        
    }   
}
