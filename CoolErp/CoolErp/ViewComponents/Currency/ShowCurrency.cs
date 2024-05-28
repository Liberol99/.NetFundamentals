using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoolErp.ViewComponents.Currency
{
    public class ShowCurrency : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string api = "https://tcmb.gov.tr/kurlar/today.xml";
            XDocument xDocument = XDocument.Load(api);
            ViewBag.value = xDocument.Descendants("Isim").ElementAt(0).Value;
            ViewBag.value2 = xDocument.Descendants("ForexSelling").ElementAt(0).Value;

            ViewBag.value3 = xDocument.Descendants("Isim").ElementAt(4).Value;
            ViewBag.value4 = xDocument.Descendants("ForexSelling").ElementAt(4).Value;

            ViewBag.value5 = xDocument.Descendants("Isim").ElementAt(8).Value;
            ViewBag.value6 = xDocument.Descendants("ForexSelling").ElementAt(8).Value;

            ViewBag.value7 = xDocument.Descendants("Isim").ElementAt(3).Value;
            ViewBag.value8 = xDocument.Descendants("ForexSelling").ElementAt(3).Value;

            ViewBag.value9 = xDocument.Descendants("Isim").ElementAt(2).Value;
            ViewBag.value10 = xDocument.Descendants("ForexSelling").ElementAt(2).Value;

            ViewBag.value11 = xDocument.Descendants("Isim").ElementAt(10).Value;
            ViewBag.value12 = xDocument.Descendants("ForexSelling").ElementAt(10).Value;

            ViewBag.value13 = xDocument.Descendants("Isim").ElementAt(14).Value;
            ViewBag.value14 = xDocument.Descendants("ForexSelling").ElementAt(14).Value;

            ViewBag.value15 = xDocument.Descendants("Isim").ElementAt(5).Value;
            ViewBag.value16 = xDocument.Descendants("ForexSelling").ElementAt(5).Value;

            ViewBag.value17 = xDocument.Descendants("Isim").ElementAt(13).Value;
            ViewBag.value18 = xDocument.Descendants("ForexSelling").ElementAt(13).Value;
            return View();
        }
    }
}