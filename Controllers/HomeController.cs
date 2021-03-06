using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NoodleHouse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Noodle House application";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact Us";
            ViewData["Message"] = "Our contact details";
            
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
