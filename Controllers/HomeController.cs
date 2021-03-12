///////////////////////////////////////////////////////////////////
// Date         Developer           Description
// 3/3/2021     Connor Thompson     Creation of SchoolContext class
// 3/3/2021     Connor Thompson     Added test data and created methods for the website
// 3/3/2021     Connor Thompson     finished class
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Controllers
{
    //tinfo200:[2021-03-03-con3nor3-dykstra1] -- initates the home controller
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
        //tinfo200:[2021-03-03-con3nor3-dykstra1] -- Test data
        public IActionResult Privacy(string first = "Connor", string last = "joe", string email = "joe123@uw.edu")
        {
            ViewData["FirstName"] = first;
            ViewData["LastName"] = last;
            ViewData["EmailAddress"] = email;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
