using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Laba9.Models;

namespace Laba9.Components
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public WeatherViewComponent(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _apiKey = "dec76bbaf8f2ecf4ef1fde9d63f75f62";
        }

        public async Task<IViewComponentResult> InvokeAsync(string region)
        {
            string defaultRegion = "Nice";
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={defaultRegion}&appid={_apiKey}";

            if (!string.IsNullOrEmpty(region))
            {
                apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={region}&appid={_apiKey}";
            }

            var response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var weather = JsonConvert.DeserializeObject<Weather>(content);
                return View(weather);
            }

            return Content("Failed to fetch weather data");
        }
    }
}