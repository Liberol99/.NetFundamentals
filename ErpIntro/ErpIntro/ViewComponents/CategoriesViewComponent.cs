using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ErpIntro.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var context = new NorthwindContext();
            List<Category> categories = context.Categories.ToList();
            return View(categories);
        }
    }
}
