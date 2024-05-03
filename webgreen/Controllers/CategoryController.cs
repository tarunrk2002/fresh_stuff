using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using webgreen.data;
using webgreen.Models;

namespace webgreen.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
           
            _db = db;
        }
        public IActionResult Index()
        {
            List<cats> ct = _db.categories.ToList();
           
           

            return View(ct);
        }
       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(cats catsobj)
        {
            _db.categories.Add(catsobj);
            
            _db.SaveChanges();
            
            return View();
        }


    }
}
