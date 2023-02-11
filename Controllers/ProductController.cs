using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web_test_app.Models;
using web_test_app.Services.Interfaces;

namespace web_test_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWarehouseService _warehouseService;
        public ProductController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            var product = new Product
            {
                Id = 1,
                Category = "Car",
                Description = "It's a nice car",
                Name = "BMW M5"
            };

            return View(product);

        }

        public IActionResult List()
        {
            var productList = _warehouseService.GetAll();

            return View(productList);

        }

        public IActionResult Data()
        {
            ViewBag.Name= "Jan";
            ViewData["Surname"] = "Jansen";
            TempData["SecondName"] = "Pieter";

            return View();
        }
    }
}
