using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using web_test_app.Services.Interfaces;

namespace web_test_app.Controllers
{
    [Authorize]
    public class ApiController : Controller
    {
        private readonly IApiService _iApiService;

        public ApiController(IApiService iApiService)
        {
            _iApiService= iApiService;
        }

        public IActionResult Index()
        {
            var response = _iApiService.Get("london");
            return View(response);
        }
    }
}
