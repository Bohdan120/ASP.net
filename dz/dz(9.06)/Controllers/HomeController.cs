using dz_7._06_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace dz_7._06_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InfoContext _context;

        public HomeController(ILogger<HomeController> logger, InfoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public ActionResult PersonalInfo()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> PersonalInfo(PersonalInfo model)
        {
            _context.PersonalInfos.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("ProfessionalSkills");
        }

        public ActionResult ProfessionalSkills()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ProfessionalSkills(ProfessionalSkills model)
        {
            _context.ProfessionalSkills.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("TestQuestion", new { id = 1 });
        }

        public async Task<ActionResult> TestQuestion(int id)
        {
            var question = await _context.TestQuestions.FindAsync(id);
            if (question == null)
            {
                return RedirectToAction("Summary");
            }
            return View(question);
        }

        [HttpPost]
        public async Task<ActionResult> TestQuestion(int id, string answer)
        {
            var question = await _context.TestQuestions.FindAsync(id);
            if (question != null)
            {
                question.Answer = answer;
                _context.TestQuestions.Update(question);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("TestQuestion", new { id = id + 1 });
        }

        public async Task<ActionResult> Summary()
        {
            var summaryViewModel = new SummaryViewModel
            {
                PersonalInfo = await _context.PersonalInfos.FirstOrDefaultAsync(),
                ProfessionalSkills = await _context.ProfessionalSkills.FirstOrDefaultAsync(),
                TestQuestions = await _context.TestQuestions.ToListAsync()
            };
            return View(summaryViewModel);
        }

        [HttpPost]
        public ActionResult Confirm()
        {
            return RedirectToAction("Index", "Home");
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
