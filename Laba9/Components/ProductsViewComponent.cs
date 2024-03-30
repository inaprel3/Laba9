using Microsoft.AspNetCore.Mvc;
using Laba9.Models;

namespace Laba9.Components
{
    public class ProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<Product> products)
        {
            return View(products);
        }
    }
}