using Microsoft.AspNetCore.Mvc;
using MVCHOT2.Models;
using System.Diagnostics;

namespace MVCHOT2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Route("about/")]
        public IActionResult About()
        {
            return View("About");
        }

    }
}