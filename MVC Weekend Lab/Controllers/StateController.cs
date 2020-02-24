using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Weekend_Lab.Models;

namespace MVC_Weekend_Lab.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StateCapitalForm()
        {
            return View();
        }

        public IActionResult StateCapitalResult(State state)
        {
            return View(state);
        }

    }
}