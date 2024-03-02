using Microsoft.AspNetCore.Mvc;

namespace Project.Controller
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
