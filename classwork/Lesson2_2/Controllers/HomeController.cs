using Lesson2_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson2_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetStream()
        {
            string file_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files/TextFile.txt");
            FileStream fs = new FileStream(file_path, FileMode.Open);
            string file_type = "text/plain";
            string file_name = "TextFile.txt";
            return File(fs, file_type, file_name);
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
