using web_test_app.Services.Interfaces;
using web_test_app.Models;

namespace web_test_app.Services
{
    public class WarehouseService : IWarehouseService
    {
        public int Save(Product product)
        {
            // logic to write data into DB
            return 2;
        }
    }
}
