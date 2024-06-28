using Microsoft.AspNetCore.Mvc;

namespace first_app.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
