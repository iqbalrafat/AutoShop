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
    }
}
