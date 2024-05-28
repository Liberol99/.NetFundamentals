using CoolBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoolBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            using var c = new Context();
            var values =  c.Categories.ToList();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            using var c = new Context();
            var value = c.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            c.Set<Category>().Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index","AdminCategory");
        }
        public IActionResult Update(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            using var c = new Context();
            category.CategoryStatus = true;
            c.Categories.Update(category);
            c.SaveChanges();
            return View(category);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            using var c = new Context();
            category.CategoryStatus = true;
            c.Categories.Add(category);
            c.SaveChanges();
            return RedirectToAction("Index","AdminCategory");
        }
    }
}
