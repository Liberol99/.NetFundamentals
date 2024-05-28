using Microsoft.AspNetCore.Mvc;

namespace CoolErp.ViewComponents.Financial
{
    public class ShowAvail : ViewComponent
    {
        public IViewComponentResult Invoke(string sonuc)
        {
            ViewBag.sonuc = sonuc;
            return View();
        }
    }
}
