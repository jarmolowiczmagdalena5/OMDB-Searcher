using Microsoft.AspNetCore.Mvc;
using OMDB_Searcher.Models;
using System.Diagnostics;

namespace OMDB_Searcher.Controllers
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

        public IActionResult Privacy()
        {
            return View("Index");
        }

        public IActionResult Login()
        {
            return View("MovieSearcher");
        }
    }
}