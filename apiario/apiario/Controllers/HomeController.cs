using apiario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace apiario.Controllers
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

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Feature()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }
    }
}