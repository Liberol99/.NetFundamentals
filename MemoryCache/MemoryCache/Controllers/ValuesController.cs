using MemoryCache.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace MemoryCache.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;

        public ValuesController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet]
        [ActionName("GetData")]
        public IActionResult GetData()
        {
            Cars[] cars;

            cars = _memoryCache.Get<Cars[]>("cars");

            if (cars == null)
            {
                cars = new Cars[]
                {
                    new Cars {Id=1,Name="Audi",Price=900},
                    new Cars {Id=2,Name="BMW",Price=800},
                    new Cars {Id=3,Name="Renault",Price=500}
                };

                Thread.Sleep(3000);

                //_memoryCache.Set("cars", cars,TimeSpan.FromSeconds(5));
                _memoryCache.Set("cars", cars);
            }

            return Ok(cars);
        }
    }
}
