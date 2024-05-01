using Microsoft.AspNetCore.Mvc;
using KhumaloCraftEmporium.Models;

namespace KhumaloCraftEmporium.Controllers
{
    public class ProductDisplayController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = ProductDisplayModel.SelectProducts();
            return View(products);
        }
    }
}
