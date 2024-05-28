using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoolErp.Controllers
{
    public class AccountingController : Controller
    {
        public class Accounting
        {
            public int AccountingId { get; set; }
            public string HesapAdi { get; set; }
            public decimal Borc { get; set; }
            public decimal Alacak { get; set; }
            public decimal Bakiye { get; set; }

        }
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44375/api/Accounting");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Accounting>>(jsonString);
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44375/api/Accounting/" + id);
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Update(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44375/api/Accounting/" + id);
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<Accounting>(jsonString);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Accounting accounting)
        {
            var httpClient = new HttpClient();
            var JsonProduct = JsonConvert.SerializeObject(accounting);
            var content = new StringContent(JsonProduct, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44375/api/Accounting/", content);
            return RedirectToAction("Index", "Accounting");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Accounting accounting)
        {
            var httpClient = new HttpClient();
            var JsonProduct = JsonConvert.SerializeObject(accounting);
            var content = new StringContent(JsonProduct, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44375/api/Accounting/", content);
            return RedirectToAction("Index", "Accounting");
        }
    }
}
