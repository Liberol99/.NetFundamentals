using Microsoft.AspNetCore.Mvc;

namespace CoolBlog.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
