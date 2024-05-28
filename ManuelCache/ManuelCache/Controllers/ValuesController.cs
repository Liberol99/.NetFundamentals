using ManuelCache.Cache;
using ManuelCache.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManuelCache.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly CacheManager _cacheManager;

        public ValuesController(CacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }

        [HttpGet]
        [ActionName("GetData")]
        public IActionResult GetData()
        {
            List<Employee>? employees = null;

            if (_cacheManager.GetCache("employees") != null)
            {
                employees = (List<Employee>?)_cacheManager.GetCache("employees");
            }
            else
            {
                employees = new List<Employee>() 
                {
                    new Employee(){Id=1,Name="Orkan"},
                    new Employee(){Id=2,Name="Semih"},
                    new Employee(){Id=3,Name="Okan"},
                };

                Thread.Sleep(3000);

                _cacheManager.SetCache("employees", employees);
            }

            return Ok(employees);
        }

        [HttpGet]
        [ActionName("RemoveCache")]
        public IActionResult RemoveCache()
        {
            if (_cacheManager.GetCache("employees") != null)
            {
                _cacheManager.ClearCache("employees");
                return Ok("Cache kaldırldı.");
            }
            else
            {
                return BadRequest("Böyle bir cache yok !");
            }
        }
    }
}
