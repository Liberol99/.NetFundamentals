using BusinessLayer.Concrete;
using CoolErp.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CoolErp.Controllers
{
    public class WaybillController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IActionResult SelectWaybill()
        {
            var values = productManager.GetProductListByCategoryAndSupplier();
            return View(values);
        }
        //1000 x (1 + 18/100)
        public IActionResult ShowWaybill(int sayi1,decimal sayi2)
        {
            var value = productManager.GetById(sayi1);
            decimal sayi3 = value.UnitPrice;
            decimal sonuc = (sayi3 * (sayi2 + (Convert.ToDecimal(0.018))));
            ViewBag.kdv = sonuc;
            return View(value);
        }
    }
}