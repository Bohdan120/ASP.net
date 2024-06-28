using FormSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormSample.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PersonController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person person)
        {
           // _logger.LogInformation($"Name:{person.Name} Age:{person.Age}");
            using(MyDbContext cnt = new MyDbContext())
            {
                cnt.People.Add(person);
                cnt.SaveChanges();
            }
            return View("ShowPerson");
        }
    }
}
