﻿using Microsoft.AspNetCore.Mvc;

namespace Project.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var a = 10;
            return View();
        }
    }
}
