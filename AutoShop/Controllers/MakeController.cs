using AutoShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Controllers
{
    public class MakeController : Controller
    {
        //make/bikes    (this is the route how the view will be called "/controller/action)
        public IActionResult Bikes()
           
        {
            Make make = new Make { Id = 1, Name = "Harley Davidson" };
            return View(make);
        }
    }
}
