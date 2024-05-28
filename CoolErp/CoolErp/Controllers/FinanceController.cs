using BusinessLayer.Concrete;
using CoolErp.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace CoolErp.Controllers
{
    public class FinanceController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            var values = productManager.GetProductListByCategoryAndSupplier();
            return View(values);
        }
        public IActionResult Calculate(int id)
        {
            var value = productManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Calculate(Product product)
        {
            ViewBag.sonuc = Convert.ToInt32(((product.UnitPrice - product.UnitsOnOrder) / product.UnitPrice * 100)).ToString();   
            return View(product);
        }
        public IActionResult Index2(decimal sayi1,decimal sayi2,decimal sayi3,decimal sayi4,decimal sayi5,decimal sayi6,decimal sayi7,decimal sayi8,decimal sayi9,decimal sayi10,decimal sayi11,decimal sayi12,decimal sayi13)
        {
            decimal gider = sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 + sayi10;
            decimal gelir = sayi11 + sayi12 + sayi13;
            decimal fark = gelir - gider;
            ViewBag.gider = Convert.ToInt32(gider);
            ViewBag.gelir = Convert.ToInt32(gelir);
            ViewBag.fark = Convert.ToInt32(fark);
            ViewBag.sayi1 = Convert.ToInt32(sayi1);
            ViewBag.sayi2 = Convert.ToInt32(sayi2);
            ViewBag.sayi3 = Convert.ToInt32(sayi3);
            ViewBag.sayi4 = Convert.ToInt32(sayi4);
            ViewBag.sayi5 = Convert.ToInt32(sayi5);
            ViewBag.sayi6 = Convert.ToInt32(sayi6);
            ViewBag.sayi7 = Convert.ToInt32(sayi7);
            ViewBag.sayi8 = Convert.ToInt32(sayi8);
            ViewBag.sayi9 = Convert.ToInt32(sayi9);
            ViewBag.sayi10 = Convert.ToInt32(sayi10);
            ViewBag.sayi11 = Convert.ToInt32(sayi11);
            ViewBag.sayi12 = Convert.ToInt32(sayi12);
            ViewBag.sayi13 = Convert.ToInt32(sayi13);
            return View();
        }
        public IActionResult CurrentRate(int page=1)
        {
            using var c = new Context(); 
            var values = productManager.GetProductListByCategoryAndSupplier().ToPagedList(page, 3);
            ViewBag.toplam = c.Products.Select(x=>x.UnitPrice).Sum();
            return View(values);
        }
        [HttpPost]
        public IActionResult CurrentRate(Financial model)
        {
            using var c = new Context();
            var values = productManager.GetProductListByCategoryAndSupplier().ToPagedList(1,3);
            ViewBag.toplam = c.Products.Select(x => x.UnitPrice).Sum();
            ViewBag.p1 = model.p1;
            ViewBag.sonuc = ViewBag.toplam / ViewBag.p1;
            decimal sonuc = ViewBag.sonuc;
            ViewBag.sonuc2 = sonuc.ToString().Substring(0,5);

            if (ViewBag.sonuc>0 && ViewBag.sonuc<1)
            {
                ViewBag.mesaj = "Düşük Seviye";
            }
            else if (ViewBag.sonuc > 1 && ViewBag.sonuc < 2)
            {
                ViewBag.mesaj = "Normal Seviye";
            }
            else
            {
                ViewBag.mesaj = "İyi Seviye";
            }
            return View(values);
        }
        public IActionResult StockManagement(int sayi1=400 , int sayi2=1)
        {
            using var c = new Context();
            var value = c.Products.Find(sayi2);
            Product product = new Product();
            product.ProductName = value.ProductName;
            product.ProductId = value.ProductId;
            product.UnitsInStock = sayi1;
            product.UnitsOnOrder = value.UnitsOnOrder;
            product.SupplierId = value.SupplierId;
            product.CategoryId = value.CategoryId;
            product.Discounted = value.Discounted;
            product.QuantityPerUnit = value.QuantityPerUnit;
            product.UnitsInCost = value.UnitsInCost;
            product.UnitPrice = value.UnitPrice;
            productManager.TUpdate(product);
            var values = productManager.GetProductListByCategoryAndSupplier();
            return View(values);
        }

        public IActionResult Kdv(decimal sayi1=0,decimal sayi2=0)
        {
            decimal sonuc = sayi1 * (1 + (sayi2/100));
            ViewBag.sonuc = sonuc;
            return View();
        }
        //liste fiyatı x (100-oran)/100
        public IActionResult Discount(decimal sayi1 = 0, decimal sayi2 = 0)
        {
            decimal sonuc = sayi1 * (100 - sayi2) / 100;
            ViewBag.sonuc = sonuc;
            return View();
        }

        public IActionResult Interest1(decimal sayi1,decimal sayi2,decimal sayi3)
        {
            decimal sonuc = (sayi1 / 100) * (sayi2 / 365) * sayi3;
            ViewBag.sonuc = Math.Round(sonuc,2);
            return View();
        }

        public IActionResult Interest2(decimal sayi1, decimal sayi2, decimal sayi3)
        {
            decimal sonuc = (sayi1 / 100) * (sayi2 / 12) * sayi3;
            ViewBag.sonuc = Math.Round(sonuc, 2);
            return View();
        }
        public IActionResult Interest3(decimal sayi1, decimal sayi2, decimal sayi3)
        {
            decimal sonuc = (sayi1 / 100) * (sayi2) * sayi3;
            ViewBag.sonuc = Math.Round(sonuc, 2);
            return View();
        }
    }
}