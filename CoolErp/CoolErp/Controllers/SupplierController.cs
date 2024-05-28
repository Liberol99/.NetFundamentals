using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class SupplierController : Controller
    {
        SupplierManager supplierManager = new SupplierManager(new EfSupplierRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            var values = supplierManager.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Supplier supplier)
        {
            supplierManager.TAdd(supplier);
            return RedirectToAction("Show", "Supplier");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = supplierManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Supplier supplier)
        {
            supplierManager.TUpdate(supplier);
            return View(supplier);
        }
        public IActionResult Delete(int id)
        {
            var value = supplierManager.GetById(id);
            supplierManager.TDelete(value);
            return RedirectToAction("Show","Supplier");
        }
    }
}
