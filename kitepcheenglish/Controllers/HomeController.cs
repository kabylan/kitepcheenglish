using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kitepcheenglish.Models;

namespace kitepcheenglish.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return RedirectToAction("Watch");
        }

        [Route("/Type")]
        public IActionResult Type()
        {
            return View();
        }


        [Route("/Watch")]
        public IActionResult Watch()
        {
            return View();
        }

    }
}
