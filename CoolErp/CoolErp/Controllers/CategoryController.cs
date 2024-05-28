using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            var values = categoryManager.GetListAll();
            return View(values);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            categoryManager.TUpdate(category);
            return RedirectToAction("Show", "Category");
        }
        public IActionResult Delete(int id)
        {
            var value = categoryManager.GetById(id);
            categoryManager.TDelete(value);
            return RedirectToAction("Show", "Category");
        }
        public IActionResult Update(int id)
        {
            var category = categoryManager.GetById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            categoryManager.TUpdate(category);
            return View(category);
        }

    }
}
