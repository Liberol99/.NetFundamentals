using CoolBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoolBlog.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            using var c = new Context();
            contact.ContactStatus = true;
            contact.ContactSubject = "Sentez Yazılım";
            contact.ContactDate = System.DateTime.Now;
            c.Contacts.Add(contact);
            c.SaveChanges();
            return View();
        }
    }
}
