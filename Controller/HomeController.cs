using Microsoft.AspNetCore.Mvc;

namespace Project.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int x = 5;
            int y = 6;
            int sum = x + y;
            Console.WriteLine(sum);
            return View();
        }
    }
}
