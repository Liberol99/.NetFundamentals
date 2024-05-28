using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoolErp.ViewComponents.Employee
{
    public class ChartCount : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}