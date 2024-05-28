using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoolBlog.ViewComponents.Webtekno
{
    public class ShowNewsBottom : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string api = "https://www.mynet.com/haber/rss/kategori/saglik/";
            XDocument xDocument = XDocument.Load(api);
            ViewBag.value = xDocument.Descendants("title").ElementAt(10).Value;
            ViewBag.value2 = xDocument.Descendants("img640x360").ElementAt(8).Value;
            ViewBag.value3 = xDocument.Descendants("description").ElementAt(9).Value;

            ViewBag.value4 = xDocument.Descendants("title").ElementAt(42).Value;
            ViewBag.value5 = xDocument.Descendants("img640x360").ElementAt(40).Value;
            ViewBag.value6 = xDocument.Descendants("description").ElementAt(41).Value;

            ViewBag.value7 = xDocument.Descendants("title").ElementAt(32).Value;
            ViewBag.value8 = xDocument.Descendants("img640x360").ElementAt(30).Value;
            ViewBag.value9 = xDocument.Descendants("description").ElementAt(31).Value;

            return View();
        }
    }
}
