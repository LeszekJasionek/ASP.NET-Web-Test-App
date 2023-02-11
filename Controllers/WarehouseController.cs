using Microsoft.AspNetCore.Mvc;
using web_test_app.Models;

namespace web_test_app.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product body)
        {
            return View();
        }

    }
}
