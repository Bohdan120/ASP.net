using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productService;
        private readonly IStringLocalizer<ProductController>? _localizer;
        private List<SelectListItem> categories;
        private List<SelectListItem> manufactureres;

        public ProductController(ProductService productService, IStringLocalizer<ProductController>? localizer)
        {
            this.productService = productService;
            _localizer = localizer;
            categories = new List<SelectListItem>() {
                new SelectListItem(localizer["Electronics"], localizer["Electronics"]),
                new SelectListItem(localizer["Electrical"],  localizer["Electrical"]),
                new SelectListItem(localizer["Food"],  localizer["Food"])
            };
            manufactureres = new List<SelectListItem>() {
                new SelectListItem(localizer["MS-Eletronics"], localizer["MS-Eletronics"]),
                new SelectListItem(localizer["MS-Electrical"], localizer["MS-Electrical"]),
                new SelectListItem(localizer["MS-Food"], localizer["MS-Food"]),
                new SelectListItem(localizer["LS-Eletronics"], localizer["LS-Eletronics"]),
                new SelectListItem(localizer["LS-Electrical"], localizer["LS-Electrical"]),
                new SelectListItem(localizer["LS-Food"], localizer["LS-Food"]),
                new SelectListItem(localizer["TS-Eletronics"], localizer["TS-Eletronics"]),
                new SelectListItem(localizer["TS-Electrical"], localizer["TS-Electrical"]),
                new SelectListItem(localizer["TS-Food"], localizer["TS-Food"])
            };
        }

        public IActionResult Index()
        {
            var products = productService.GetProducts();

            return View(products);
        }
        public IActionResult Create()
        {
            var product = new Product();
            ViewBag.CategoryName = categories;
            ViewBag.Manufacture = manufactureres;

            return View(product);
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var products = productService.AddProduct(product);
                return View("Index", products);
            }
            else
            {
                ViewBag.CategoryName = categories;
                ViewBag.Manufacturer = manufactureres;
                return View(product);
            }
        }
    }
}
