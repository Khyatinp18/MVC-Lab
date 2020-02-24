using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Weekend_Lab.Models;

namespace MVC_Weekend_Lab.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MileageForm()
        {
            return View();
        }


        //double mpg, double gallons, double trip
        //Tripometer.MPG = mpg
        public IActionResult MileageResult(Tripometer trips)
        {

            ////Tripometer trips = new Tripometer
            ///trip mpg = MGP etc..
            return View(trips);
           
        }
    }
}