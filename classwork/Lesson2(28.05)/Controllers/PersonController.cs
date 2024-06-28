using Lesson2_28._05_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson2_28._05_.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(int id)
        {
            string name = Request.Form["name"];
            int age = Convert.ToInt32(Request.Form["age"]);        // return $"name={person.Name}  age={person.Age}";
            return $"name={name}  age={age}";
        }
    }
}
