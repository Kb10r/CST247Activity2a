using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult message()
        {
            return View("message");
        }

        public IActionResult welcome(String name, int secretNumber=13) 
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;

            return View("welcome");
        }
    }
}
