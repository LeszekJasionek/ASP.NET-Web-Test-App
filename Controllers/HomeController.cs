using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using web_test_app.Models;

namespace web_test_app.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [Route("test-route/{name}")]
        public IActionResult Product(string name)
        {
            return View();
        }

    }
}
