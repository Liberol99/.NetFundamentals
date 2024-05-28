using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoolErp.ViewComponents.ToDo
{
    public class ShowToDo : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            using var c = new Context();
            var values = c.Orders.Include(x=>x.Customer).Where(x => x.EmployeeId == id).ToList();
            return View(values);
        }
    }
}
