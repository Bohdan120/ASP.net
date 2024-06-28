using Microsoft.AspNetCore.Mvc;
using Pagination_20._06_.Models;
using System.Diagnostics;

namespace Pagination_20._06_.Controllers
{
    public class HomeController : Controller
    {
        UsersContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UsersContext db)
        {
            _logger = logger;
            this.db = db;

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
