using Microsoft.AspNetCore.Mvc;

namespace web_test_app.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
