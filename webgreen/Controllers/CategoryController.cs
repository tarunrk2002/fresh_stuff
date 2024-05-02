using Microsoft.AspNetCore.Mvc;
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
            List<string> categories = new List<string>();
            categories.Add("f4ef4ef");

            return View(ct);
        }
       
        public IActionResult Create()
        {
            return View();
        }

        
    }
}
