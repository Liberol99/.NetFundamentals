using CoolBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CoolBlog.ViewComponents.Blog
{
    public class ShowMoreBlogs : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Random random = new Random();
            int randsayi1 = random.Next(1,3);
            using var c = new Context();
            var values = c.Blogs.Include("Category").Where(x => x.CategoryId == 2).ToList();
            return View(values);
        }
    }
}
