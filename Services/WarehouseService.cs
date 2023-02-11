using web_test_app.Services.Interfaces;
using web_test_app.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace web_test_app.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly DbTestContext _context;

        public WarehouseService(DbTestContext context)
        {
            _context = context;
        }

        public int Save(Product product)
        {
            // logic to write data into DB

            _context.Products.Add(product);

            if(_context.SaveChanges() > 0)
            {
                System.Console.WriteLine("Success");
            }

            _context.SaveChanges();

            return product.Id;
        }

        public List<Product> GetAll()
        {
            var products = _context.Products.ToList();
            return products;
        }
    }
}
