using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoolBlog.ViewComponents.Webtekno
{
    public class ShowNews : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string api = "https://www.mynet.com/haber/rss/kategori/teknoloji/";
            XDocument xDocument = XDocument.Load(api);
            ViewBag.value = xDocument.Descendants("title").ElementAt(2).Value;
            ViewBag.value2 = xDocument.Descendants("img640x360").ElementAt(0).Value;
            ViewBag.value3 = xDocument.Descendants("description").ElementAt(1).Value;

            ViewBag.value4 = xDocument.Descendants("title").ElementAt(4).Value;
            ViewBag.value5 = xDocument.Descendants("img640x360").ElementAt(2).Value;
            ViewBag.value6 = xDocument.Descendants("description").ElementAt(3).Value;

            ViewBag.value7 = xDocument.Descendants("title").ElementAt(9).Value;
            ViewBag.value8 = xDocument.Descendants("img640x360").ElementAt(7).Value;
            ViewBag.value9 = xDocument.Descendants("description").ElementAt(8).Value;

            return View();
        }
    }
}
