using lesson4_03._06_.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson4_03._06_.Controllers
{
    public class ProductController : Controller
    {
        private MyDbContext db = new MyDbContext();

        public ActionResult Index()
        {
            var products = db.Products.ToList(); 
            return View(products);
        }
    }
}
