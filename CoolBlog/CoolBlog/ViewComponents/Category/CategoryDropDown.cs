using CoolBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoolBlog.ViewComponents.Category
{
    public class CategoryDropDown : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            var values = c.Categories.ToList();
            return View(values);
        }
    }
}
