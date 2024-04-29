using Microsoft.AspNetCore.Mvc;
using webgreen.data;

namespace webgreen.Controllers
{
    public class CategoryController : Controller
    {

        //public CategoryController(ApplicationDbContext db) 
        //{
        //   var g =  db.categories.ToList();
        //}
        public IActionResult Index()
        {
            return View("Category");
        }

        public IActionResult Next()
        {
            return View();
        }

    }
}
