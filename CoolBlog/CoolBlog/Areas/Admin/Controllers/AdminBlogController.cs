using CoolBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using X.PagedList;

namespace CoolBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        public IActionResult Index(int page=1)
        {
            using var c = new Context();
            var values = c.Blogs.ToPagedList(page, 3);
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            using var c = new Context();
            var value = c.Blogs.Find(id);
            c.Blogs.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index","AdminBlog");
        }
        public IActionResult Update(int id)
        {
            using var c = new Context();
            var value = c.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Blog blog)
        {
            using var c = new Context();
            blog.BlogStatus = true;
            blog.BlogCreateDate = DateTime.Now.Date;
            c.Blogs.Update(blog);
            c.SaveChanges();
            return View(blog);
        }
        public IActionResult Add()
        {
            using var c = new Context();
            var values1 =  c.Set<Category>().ToList();
            var values2 =  c.Set<Writer>().ToList();
            var myTuple = (values1,values2);
            return View(myTuple);
        }
        [HttpPost]
        public IActionResult Add(Blog blog)
        {
            using var c = new Context();
            blog.BlogStatus = true;
            blog.BlogCreateDate = DateTime.Now.Date;
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index", "AdminBlog");
        }
    }
}
