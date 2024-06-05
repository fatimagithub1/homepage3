using homepage3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace homepage3.Controllers
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
            ViewData["Message"] = "Join us our mission to protect our occeans by reducing plastic pollution.<br> And make consumer more \r\n     aware of their role when using plasti!";
            return View();
        }

        public IActionResult Index1()
        {
            TempData["Message"] = "Join us our mission to protect our occeans by reducing plastic pollution.<br> And make consumer more \r\n     aware of their role when using plasti!";
            return View();
        }
        public IActionResult Index2()
        {
            ViewData["Message"] = "Join us our mission to protect our occeans by reducing plastic pollution.<br> And make consumer more \r\n     aware of their role when using plasti!";
            return View();

            ViewBag.Message = "Join us our mission to protect our occeans by reducing plastic pollution.<br> And make consumer more \\r\\n     aware of their role when using plasti!";
            return View();

            TempData["Message"] = "Join us our mission to protect our occeans by reducing plastic pollution.<br> And make consumer more \r\n     aware of their role when using plasti!";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult PressInquires()
        {
            return View();
        }

        public IActionResult AboutUs()
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
