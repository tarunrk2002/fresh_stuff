using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using webgreen.data;
using webgreen.Models;

namespace webgreen.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext db;
        public CategoryController(ApplicationDbContext db)
        {
           
            this.db = db;
        }
        public IActionResult Index()
        {
            List<cats> ct = db.categories.ToList();
           
           

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
                    db.categories.Add(catsobj);

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();       
        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            cats catsedit = db.categories.Find(id);
            return View(catsedit);
        }

        [HttpPost]
        public IActionResult Edit()
        {

           
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }


    }
}
