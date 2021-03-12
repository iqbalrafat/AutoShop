using AutoShop.AppDbContext;
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
        private AutoDbContext _db;
        public MakeController(AutoDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()           
        {
            var data = _db.Makes.ToList();
            return View(data);
        }
        //HTTP Get Request
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Make make)
        {
            if (ModelState.IsValid)
            {
                var data = _db;
                data.Add(make);
                data.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(make);
        }
    }
}
