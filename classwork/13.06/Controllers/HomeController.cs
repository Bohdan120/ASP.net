using _13._06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _13._06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (string.IsNullOrEmpty(product.Title))
            {
                ModelState.AddModelError("Title", "Title is empty");
            }
            if(product.Price <= 0)
            {
                ModelState.AddModelError("Price", "Ціна не може бути менше нуля");
            }

            if (ModelState.IsValid)
                return Content("Success");
            return View(product);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
