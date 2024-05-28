using ApiLayer.Models;
using ApiLayer.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingController : ControllerBase
    {
        private readonly IAccountingService _accountingService;

        public AccountingController(IAccountingService accountingService)
        {
            _accountingService = accountingService;
        }

        //AccountingManager accountingManager = new AccountingManager();

        [HttpGet]
        public IActionResult GetAllAccounting()
        {
            var values = _accountingService.GetAllAccounting();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetAccounting(int id)
        {
            var value = _accountingService.GetAccounting(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddAccounting(Accounting accounting)
        {
            _accountingService.AddAccounting(accounting);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAccounting(Accounting accounting)
        {
            _accountingService.UpdateAccounting(accounting);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAccounting(int id)
        {
            _accountingService.DeleteAccounting(id);
            return Ok();
        }
    }
}
