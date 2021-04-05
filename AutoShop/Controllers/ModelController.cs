using AutoShop.AppDbContext;
using AutoShop.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Controllers
{
    public class ModelController : Controller
    {
        //perform dependency Injection
        private readonly AutoDbContext _db;
        [BindProperty]
        public ModelViewModel ModelVM { get; set;}
        public ModelController(AutoDbContext db)
        {
            _db = db;
            ModelVM = new ModelViewModel()
            {
                Makes = _db.Makes.ToList(),
                Model = new Models.Model()
            };

        }            
        public IActionResult Index()
        {
            var model = _db.Models.Include(m => m.Make); //It will take all  Make
            return View(model);
        }
        //Create 
        public IActionResult Create()
        {
            return View(ModelVM);
        }
        [HttpPost,ActionName("Create")]
        public IActionResult CreatePost()
        {
            if(!ModelState.IsValid)
            {
                return View(ModelVM);
            }
            _db.Models.Add(ModelVM.Model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            ModelVM.Model = _db.Models.Include(m => m.Make).SingleOrDefault(m => m.Id == id);
            if(ModelVM.Model==null)
            {
                return NotFound();
            }
            return View(ModelVM);
        }
        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost()
        {
            if (!ModelState.IsValid)
            {
                return View(ModelVM);
            }
            _db.Update(ModelVM.Model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Delete (int id)
        {
            var data = _db;
            var model = data.Models.Where(m => m.Id == id).FirstOrDefault();
            if (model == null)
            {
                return StatusCode(401, NotFound());
            }
            _db.Models.Remove(model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }     
    }
}
