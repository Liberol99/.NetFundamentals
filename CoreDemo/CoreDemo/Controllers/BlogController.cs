using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        [HttpGet]
        public IActionResult Index()
        {
            //Category tablosundaki verileri de çekmek için bu metod kullanıldı
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.id = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }
    }
}