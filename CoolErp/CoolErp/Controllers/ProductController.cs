using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoolErp.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        SupplierManager supplierManager = new SupplierManager(new EfSupplierRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = productManager.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var value = productManager.GetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Show","Product");
        }

        [HttpGet]
        public IActionResult Add()
        {
            var values1 = supplierManager.GetListAll();
            var values2 = categoryManager.GetListAll();
            var myTuple = (values1,values2);
            return View(myTuple);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            //ProductValidator productValidator = new ProductValidator();
            //ValidationResult results = productValidator.Validate(product);
            //if (results.IsValid)
            //{
            //    product.Discounted = true;
            //    productManager.TAdd(product);
            //    return RedirectToAction("Show", "Product");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
            //    }
            //}

            //return View();

            product.Discounted = true;
            productManager.TAdd(product);
            return RedirectToAction("Show", "Product");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = productManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            product.Discounted = true;
            productManager.TUpdate(product);
            return View(product);
        }
        [HttpGet]
        public IActionResult Show()
        {
            var values = productManager.GetProductListByCategoryAndSupplier();
            return View(values);
        }

        public IActionResult Search(string string1)
        {
            using var c = new Context();
            TempData["supId"] = c.Products.Include(x => x.Supplier).Where(x => x.Supplier.CompanyName == string1).Select(x => x.Supplier.SupplierId).FirstOrDefault();
            return RedirectToAction("SearchInfo","Product");
        }
        public IActionResult SearchInfo()
        {
            int supId = Convert.ToInt32(TempData["supId"]);
            using var c = new Context();
            var values = c.Products.Include(x => x.Supplier).Where(x => x.Supplier.SupplierId == supId).ToList();
            return View(values);
        }

    }
}
