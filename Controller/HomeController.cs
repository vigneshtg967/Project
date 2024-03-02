using Microsoft.AspNetCore.Mvc;

namespace Project.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
            var change = 10;
            return View();
        }
    }
}
