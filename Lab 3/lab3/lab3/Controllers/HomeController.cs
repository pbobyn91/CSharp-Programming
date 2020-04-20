using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab3.Model;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Razor()
        {
            return View();
        }

        public IActionResult CreatePerson()
        {
            return View();
        }

        public IActionResult DisplayPerson(Person person)
        {
            return View(person);
        }
    }
}