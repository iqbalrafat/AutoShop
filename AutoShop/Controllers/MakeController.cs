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
        [HttpPost]
        public IActionResult Delete(int Id)
        {
           var data = _db;
           var make = data.Makes.Where(m => m.Id == Id).FirstOrDefault();
            if (make == null)
            {
                return StatusCode(401,NotFound());
            }
            _db.Makes.Remove(make);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int Id)
        {
            var data = _db;
            var make = data.Makes.Where(m => m.Id == Id).FirstOrDefault();
            if (make == null)
            {
                return StatusCode(401, NotFound());
            }
            return View(make);
        }
        [HttpPost]
        public IActionResult Edit(Make make)
        {        
            if (ModelState.IsValid)
            {
                _db.Update(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
             }
                return StatusCode(401, NotFound());
        }
    }
}
