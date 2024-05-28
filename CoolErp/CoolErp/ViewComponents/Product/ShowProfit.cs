using Microsoft.AspNetCore.Mvc;

namespace CoolErp.ViewComponents.Product
{
    public class ShowProfit : ViewComponent
    {
        public IViewComponentResult Invoke(string sonuc)
        {
            ViewBag.sonuc = sonuc;
            return View();
        }
    }
}