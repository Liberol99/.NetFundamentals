using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoolErp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeRepository());

        [HttpGet]
        public IActionResult Show()
        {
            var values = employeeManager.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var value = employeeManager.GetById(id);
            employeeManager.TDelete(value);
            return RedirectToAction("Show","Employee");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            employeeManager.TAdd(employee);
            return RedirectToAction("Show","Employee");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = employeeManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            employeeManager.TUpdate(employee);
            return View(employee);
        }
    }
}
