using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Weekend_Lab.Models;

namespace MVC_Weekend_Lab.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNumbersForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNumberResult(AddNum addnum)
        {
            return View(addnum);
        }
    }
}