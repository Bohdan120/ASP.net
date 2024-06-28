using Microsoft.AspNetCore.Mvc;

namespace _10._06.Areas.Service.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
