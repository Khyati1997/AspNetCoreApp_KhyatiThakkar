using System.Diagnostics;
using AspNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor to initialize the logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Main Index action to display a greeting message
        public IActionResult Index()
        {
            // Pass a custom greeting message to the view
            ViewData["Message"] = "Hello, Khyati!";
            return View();
        }

        // Privacy action to show the privacy policy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Error action to handle errors and display an error page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
