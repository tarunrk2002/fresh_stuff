using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using webgreen.DataAccess.data;

using webgreen.Models.Models;
using webgreen.Repository.IRepository;

namespace webgreen.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller   
    {
        private readonly Iunitofwork db;
        public ProductController(Iunitofwork db)
        {
            
           
            this.db = db;
        }
        public IActionResult Index()
        {
            var pd = db.Product.GetAll().ToList();
           
           

            return View(pd);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product productobj)
        {
           
                if (ModelState.IsValid)
                {
                    db.Product.add(productobj);

                    db.save();
                    TempData["ok"] = "created new product";
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

            Product? productedit = db.Product.Get(u=>u.Id==id);
            return View(productedit);
        }

        [HttpPost]
        public IActionResult Edit(Product producteditt)
        {
            db.Product.update(producteditt);

            db.save();
            return RedirectToAction("Index");

            
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product? productedit = db.Product.Get(u => u.Id == id);
            return View(productedit);
        }

        [HttpPost]
        public IActionResult Delete(Product deleteproduct)
        {
            db.Product.remove(deleteproduct);

            db.save();
            return RedirectToAction("Index");


        }

    }
}
