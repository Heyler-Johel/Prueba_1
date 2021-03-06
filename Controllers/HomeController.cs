using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Prueba_1.Models;



namespace Prueba_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(string username, string password)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                return View("Index");
            }
            else
            {
                return View("Login");
            }
        }

        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username != null && password != null && username.Equals("acc1") && password.Equals("123"))
            {
                HttpContext.Session.SetString("username", username);
                return View("Index");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }
        }



        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username"); // it will clear the session at the end of request
            return RedirectToAction("Login", "Home");
            //return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
