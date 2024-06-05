using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using webgreen.DataAccess.data;

using webgreen.Models.Models;
using webgreen.Repository.IRepository;

namespace webgreen.Controllers
{
    public class CategoryController : Controller   
    {
        private readonly Iunitofwork db;
        public CategoryController(Iunitofwork db)
        {
            
           
            this.db = db;
        }
        public IActionResult Index()
        {
            List<cats> ct = db.Cats.GetAll().ToList();
           
           

            return View(ct);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(cats catsobj)
        {
           
                if (ModelState.IsValid)
                {
                    db.Cats.add(catsobj);

                    db.save();
                    TempData["ok"] = "created new category";
                    return RedirectToAction("Index");
                }
                return View();       
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            cats? catsedit = db.Cats.Get(u=>u.id==id);
            return View(catsedit);
        }

        [HttpPost]
        public IActionResult Edit(cats editcats)
        {
            db.Cats.update(editcats);

            db.save();
            return RedirectToAction("Index");

            
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            cats? catsedit = db.Cats.Get(u => u.id == id);
            return View(catsedit);
        }

        [HttpPost]
        public IActionResult Delete(cats editcats)
        {
            db.Cats.remove(editcats);

            db.save();
            return RedirectToAction("Index");


        }

        public IActionResult next()
        {
            return View();
        }

    }
}
