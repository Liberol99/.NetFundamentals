using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class Barcode : Controller
    {
        SupplierManager supplierManager = new SupplierManager(new EfSupplierRepository());
        public IActionResult Index(int id)
        {
            var value = supplierManager.GetById(id);
            return View(value);
        }
        public IActionResult Show()
        {
            var values = supplierManager.GetListAll();
            return View(values);
        }
    }
}
