using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CoolErp.Controllers
{
    public class AccountController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeRepository());
        
        public IActionResult Index(int id)
        {
            var value = employeeManager.GetById(id);
            return View(value);
        }

        public IActionResult ProductInfo(int id)
        {
            using var c = new Context();
            var value = c.Products.Include("Category").Include("Supplier").Where(x => x.ProductId == id).FirstOrDefault();
            return View(value);
        }

        public IActionResult Map()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            EmployeeValidator employeeValidator = new EmployeeValidator();
            ValidationResult results = employeeValidator.Validate(employee);
            if (results.IsValid)
            {
                employee.BirthDate = Convert.ToDateTime("1994-10-05 01:41:11.6895832");
                employee.HireDate = Convert.ToDateTime("2021-05-08 01:41:11.6895832");
                employee.Salary = Convert.ToDecimal(10000);
                employeeManager.TAdd(employee);
                ViewBag.mesaj = "Kayıt İşlemi Başarılı";
                return View();
            }
            else
            {
                ViewBag.mesaj = "Kayıt İşlemi Başarısız !";
                return View(employee);
            }
        }
    }
}
