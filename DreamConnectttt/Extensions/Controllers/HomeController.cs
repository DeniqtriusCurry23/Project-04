using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DreamConnectttt.Models;

namespace DreamConnectttt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "We here at Dream Connect have strong beliefs that dreams are a gateway to an alternate reality.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Feel free to reach out to us here at Dream Connect";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
