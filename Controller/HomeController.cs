﻿using Microsoft.AspNetCore.Mvc;

namespace Project.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Prompting the user to enter the first number
        Console.Write("Enter a number: ");
        // Reading the first number entered by the user and converting it to an integer
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Prompting the user to enter the second number
        Console.Write("Enter another number: ");
        // Reading the second number entered by the user and converting it to an integer
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Displaying addition of the two numbers
        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);

        // Displaying subtraction of the two numbers
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);

        // Displaying multiplication of the two numbers
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);

        // Displaying division of the two numbers
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

        // Displaying modulus (remainder) of the two numbers
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
            return View();
        }
    }
}
