using Biit_Vsiter_Tracking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Biit_Vsiter_Tracking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult sign()
        {
            return View();
        }
        public IActionResult Alerts()
        {
            return View();
        }
        public IActionResult GuardAlertsScreen()
        {
            return View();
        }
        public IActionResult AdminHomePage()
        {
            return View();
        }
        public IActionResult AddPerson()
        {
            return View();
        }
        public IActionResult AddCamera()
        {
            return View();
        }
        public IActionResult AddPath()
        {
            return View();
        }

        public IActionResult AddGuard()
        {
            return View();
        }
        public IActionResult AddDestination()
        {
            return View();
        }
        public IActionResult CurrentVisiter()
        {
            return View();
        }
        public IActionResult Teacheravailable()
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
