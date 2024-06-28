using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using tehHelperSample.Models;

namespace tehHelperSample.Controllers
{
    public class HomeController : Controller
    {
        IEnumerable<Company> companies = new List<Company>
        {
            new Company( 1, "Apple"),
            new Company(2, "Samsung"),
            new Company(3, "Google")
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Companies = new SelectList(companies, "Id", "Name");
            return View();
        }
        [HttpPost]
        public string Create(Product product)
        {
            Company? company = companies.FirstOrDefault(c => c.Id == product.CompanyId);
            return $"Додано новий елемент: {product.Name} ({company?.Name})";
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
