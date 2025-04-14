using System.Diagnostics;
using AssetManagement_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Layout.<Header> - Navigation for Views/Home
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Features()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }

        public IActionResult Resources()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        // Layout.<Footer> - Navigation for Views/Home
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
