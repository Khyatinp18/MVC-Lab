using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Weekend_Lab.Models;

namespace MVC_Weekend_Lab.Controllers
{
    public class MadlibController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MadlibStoryForm()
        {
            return View();
        }

        public IActionResult MadlibStroryResult(Madlib madlib)
        {
            return View(madlib);
        }
    }
}