using CoolBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoolBlog.ViewComponents.Writer
{
    public class SideBarWriter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            var values = c.Writers.ToList();
            return View(values);
        }
    }
}
