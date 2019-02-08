using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class NewHomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowText()
        {
            return Content("Hi..! This is assignment added text. ");
        }
        public IActionResult ShowJSON()
        {
            return Json(new { name = "fav", quote = "Quote-Never giveup." });
        }
        public IActionResult ShowHTML()
        {
            var h = "<!DOCTYPE html><html><body>Added show html functinality." +
            "<br><br> <a href='/NewHome'>back  to html </a></body></html>";
            return Content(h, "text/html");
        }

        public IActionResult ShowView()
        {
            return View();
        }
        public IActionResult Calculations()
        {
            return View("Views/NewHome/Calculations.cshtml");
        }

    }
}
