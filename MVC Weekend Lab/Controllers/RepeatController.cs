using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Weekend_Lab.Models;

namespace MVC_Weekend_Lab.Controllers
{
    public class RepeatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RepeatWordForm()
        {
            return View();
        }

        public IActionResult RepeatWordResult(RepeatWord repeatWord)
        {
            return View(repeatWord);
        }
    }
}