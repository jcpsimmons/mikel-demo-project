using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using job_application_project.Models;

namespace job_application_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string forwardText)
        {
            var tempArray = forwardText.ToCharArray();
            Array.Reverse(tempArray);
            forwardText = new string(tempArray);
            ViewBag.ReversedText = forwardText;
            return View();
            //return Content($"need to flip {forwardText}");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
