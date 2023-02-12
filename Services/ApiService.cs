using Newtonsoft.Json;
using System.Net;
using web_test_app.Models;
using web_test_app.Services.Interfaces;
using static System.Net.WebRequestMethods;

namespace web_test_app.Services
{
    public class ApiService : IApiService
    {
        private const string API_KEY = "Z8NCYM3G4D8PPMU6PNH4ZKMZW";

        public WeatherResponse Get(string city)
        {
            var url =$"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city},UK?key={API_KEY} ";

            var web = new WebClient();

            var response = web.DownloadString(url);

            var myDeserializedClass = JsonConvert.DeserializeObject<WeatherResponse>(response); //json2csharp

            return myDeserializedClass;
        }
    }
}
