using _20._06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _20._06.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Samsung Galaxy S21", Price = 899.99, ImageUrl="https://hotline.ua/img/tx/260/2604053655.jpg", Category = "Телефони" },
            new Product { Id = 2, Name = "iPhone 13 Pro", Price = 1099.99, ImageUrl ="https://macroom.com.ua/files/products/iphone-13-pro-blue-select_2.800x600w.png?2745a613835fbf074fcf83784851117a", Category = "Телефони" },
            new Product { Id = 3, Name = "MacBook Air", Price = 1299.99, ImageUrl ="https://hotline.ua/img/tx/391/3919274075.jpg", Category = "Ноутбуки" },
            new Product { Id = 4, Name = "Dell XPS 15", Price = 1499.99, ImageUrl ="https://hotline.ua/img/tx/414/4145884875.jpg", Category = "Ноутбуки" }
        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Details(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult Index(string searchTerm, string category, int page = 1)
        {
            int pageSize = 10;
            var filteredProducts = Products.Where(p =>
                (string.IsNullOrEmpty(searchTerm) || p.Name.Contains(searchTerm)) &&
                (string.IsNullOrEmpty(category) || p.Category == category)).ToList();

            var paginatedProducts = filteredProducts.Skip((page - 1) * pageSize).Take(pageSize);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)filteredProducts.Count() / pageSize);
            ViewBag.SearchTerm = searchTerm;
            ViewBag.Category = category;

            return View(paginatedProducts);
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
