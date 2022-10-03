using Microsoft.AspNetCore.Mvc;
using OMDB_Searcher.Models;

namespace OMDB_Searcher.Controllers
{
    public class TestController : Controller
    {
        public IActionResult test(User model)
        {
            User user = new User();
            user.Name = "dsadas";

            ViewData["ReturnUrl"] = "dasdasas";
            return View(user);
        }
    }
}
