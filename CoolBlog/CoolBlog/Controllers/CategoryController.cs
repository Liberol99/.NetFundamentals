using CoolBlog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoolBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int id)
        {
            using var c = new Context();
            var value = c.Blogs.Include("Category").Where(x => x.BlogId == id).FirstOrDefault();
            return View(value);
        }
        public IActionResult Show(int id)
        {
            using var c = new Context();
            var values = c.Blogs.Include("Category").Where(x => x.CategoryId == id).ToList();
            var value = c.Categories.Find(id);
            ViewBag.categoryName = value.CategoryName;
            return View(values);
        }
        public IActionResult Search(string string1)
        {
            using var c = new Context();
            var values = c.Blogs.Include("Category").Where(x => x.Category.CategoryName == string1).ToList();
            return View(values);
        }
    }
}
