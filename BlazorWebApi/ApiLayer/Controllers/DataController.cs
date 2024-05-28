using BlazorWebAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class DataController : ControllerBase
    {

        [HttpGet]
        [ActionName("GetDataTable")]
        public IActionResult GetDataTable()
        {
            using var context = new BasakContext();
            List<ErpInventory> myList = context.ErpInventories.Where(x=>x.RecId< 10475).ToList();

            return Ok(myList);
        }

        //%7B%22employeeCode%22%3A%220001%22%2C%22employeeName%22%3A%22Can%20Kaya%22%7D
        [HttpGet]
        [ActionName("GetEmployees")]
        public IActionResult GetEmployees([FromQuery] string encodedData)
        {
            string originalData = Uri.UnescapeDataString(encodedData);
            var exp = System.Text.Json.JsonSerializer.Deserialize<ExpandoObject>(originalData);
            return Ok(exp);
        }

        
    }
}
