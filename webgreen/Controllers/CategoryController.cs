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

            return View();
        }

        public IActionResult Next()
        {
            return View();
        }

    }
}
