using BirthdayCardGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BirthdayCardGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BirthdayForm(Birthday birthday)
        {
            if (ModelState.IsValid)
            {
                //ViewBag.Name = string.Format("Name: {0}, {1}, {2}", From, To, Message);
                //return Redirect("");
                return View("BirthdayForm",birthday);
                //return Content($"From: {birthday.From}\\t To: {birthday.To}\\t Message: {birthday.Message}");

            }
            return View("Index");
            //return RedirectToAction("Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}