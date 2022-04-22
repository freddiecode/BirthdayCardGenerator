﻿using BirthdayCardGenerator.Models;
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

                return View("BirthdayForm", birthday);


            }
            return View("Index");


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}