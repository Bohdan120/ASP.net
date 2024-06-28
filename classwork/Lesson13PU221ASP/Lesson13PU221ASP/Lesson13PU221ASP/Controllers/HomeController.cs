using Lesson13PU221ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace Lesson13PU221ASP.Controllers
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
        public string GetCulture(string code="")
        {
            if(!String.IsNullOrEmpty(code))
            {
              CultureInfo.CurrentCulture=new CultureInfo(code);
              CultureInfo.CurrentUICulture=new CultureInfo(code);
            }
            return $"CurrentCulture:{CultureInfo.CurrentCulture.Name},CurrentUICulture:{CultureInfo.CurrentUICulture.Name} Date:{DateTime.Now.ToString()}";
           
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
