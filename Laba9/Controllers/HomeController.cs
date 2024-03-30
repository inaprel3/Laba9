using Microsoft.AspNetCore.Mvc;
using Laba9.Models;

namespace Laba9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Парасолька", Price = 10.99 },
                new Product { ID = 2, Name = "Сонячні окуляри", Price = 20.49 },
                new Product { ID = 3, Name = "Тепла шуба", Price = 30.99 }
            };

            return View(products);
        }

        public IActionResult Weather(string region)
        {
            return ViewComponent("Weather", region);
        }
    }
}