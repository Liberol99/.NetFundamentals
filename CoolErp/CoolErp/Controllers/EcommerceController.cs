using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoolErp.Controllers
{
    public class EcommerceController : Controller
    {
        public List<string> list;
        public IActionResult Index()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.n11.com/erkek-giyim-aksesuar/tisort-atlet");
            //var myList = doc.DocumentNode.SelectNodes("//div/img/@src");
            var myList = doc.DocumentNode.SelectNodes("//div/img/@src");
            list = new List<string>();
            foreach(var item in myList)
            {
                HtmlAttribute src = item.Attributes["src"];
                list.Add(src.Value);
            }

            return View(list);
        }
    }
}