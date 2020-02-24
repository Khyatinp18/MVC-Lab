using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Weekend_Lab.Models;

namespace MVC_Weekend_Lab.Controllers
{
    public class DivideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DivideNumbersForm()
        {
            return View();
        }

        public IActionResult DivideResult(DivideNum dividenum)
        {
            return View(dividenum);
        }
    }
}