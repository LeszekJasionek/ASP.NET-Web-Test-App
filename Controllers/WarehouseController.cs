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
            //ModelState.IsValid - A statement that determines whether the data that came in agrees with the attributes of a given model

            if(!ModelState.IsValid)
            {              
                return View(body);

                //Again, redirection to the view, throw in the values that the user has already entered. And thanks to the fact that we use a model,
                //the user will keep the data that he has already entered and the data will be entered into the form again.
            }


            // logic to write to the product model

            return RedirectToAction("Add");
        }

    }
}
