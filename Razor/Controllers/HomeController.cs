using Microsoft.AspNetCore.Mvc;
using Razor.Models;
namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product product = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };
            ViewBag.StockLevel = 2;
            return View(product);
        }
        public ViewResult Array()
        {
            Product[] products =
            {
                new Product {ProductID = 1, Name = "Kayak", Price = 275M },
                new Product {ProductID = 2, Name = "Lifejacket", Price = 48.95M },
                new Product {ProductID = 3, Name = "Soccer ball", Price = 19.5M },
                new Product {ProductID = 4, Name = "Corner flag", Price = 34.95M }
            };
            return View(products);
        }
    }
}
