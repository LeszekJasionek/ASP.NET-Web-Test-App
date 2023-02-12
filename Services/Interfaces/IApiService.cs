using web_test_app.Models;

namespace web_test_app.Services.Interfaces
{
    public interface IApiService
    {
        WeatherResponse Get(string city);
    }
}
