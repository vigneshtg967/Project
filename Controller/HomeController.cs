using Microsoft.AspNetCore.Mvc;

namespace Project.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int x = 5;
            int y = 6;
            int z = 7;
            int sum = x + y + z;
            Console.WriteLine(sum);
            return View();
        }
    }
}
