using Microsoft.AspNetCore.Mvc;

namespace Project.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var message = "Good Morning";
            var changevicky = 20;
            return View();
        }
    }
}
