using lesson3_30._05_.infrastruct;
using lesson3_30._05_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lesson3_30._05_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITimeService timeService;

        public HomeController(ITimeService timeService)
        {
            this.timeService = timeService;
        }

        public string Index()
        {
            ITimeService? timeservice = HttpContext.RequestServices.GetService<ITimeService>();
            return timeService?.Time ?? "Underined";
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
