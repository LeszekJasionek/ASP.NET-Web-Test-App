using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web_test_app.Models;

namespace web_test_app.Controllers
{
    public class ProductController : Controller
    {
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
            var productList = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Category = "Car",
                    Description = "It's a nice car",
                    Name = "BMW M5"
                },
                new Product
                {
                    Id = 2,
                    Category = "Drinks",
                    Description = "It is very refreshing",
                    Name = "VW Golf 8"
                },
                new Product
                {
                    Id = 3,
                    Category = "Plant",
                    Description = "It's a prickly plant ",
                    Name = "The Cactus"
                },

            };

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
