using JwtWebToken.Models;
using JwtWebToken.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtWebToken.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public static readonly object lockObject = new object();

        public readonly IConfiguration _configuration;
        public readonly ITokenService _tokenService;

        public class Message
        {
            public long RecId { get; set; } = 0;
            public string Content { get; set; } = string.Empty;
        }

        public TokenController(IConfiguration configuration, ITokenService tokenService)
        {
            _configuration = configuration;
            _tokenService = tokenService;
        }

        [AllowAnonymous]
        [HttpGet]
        [ActionName("GetToken")]
        public IActionResult GetToken()
        {
            Token token = new Token();
            lock (lockObject)
            {
                token = _tokenService.CreateToken(_configuration);
            }
            return Ok(token);
        }

        [Authorize]
        [HttpGet]
        [ActionName("ShowMessage")]
        public IActionResult ShowMessage([FromQuery] string quickMessage)
        {
            Response response = new Response();
            response.Data = quickMessage;
            return Ok(response);
        }

        [Authorize]
        [HttpPost]
        [ActionName("AddMessage")]
        public IActionResult AddMessage([FromQuery] string title, [FromBody] Message message)
        {
            Response response = new Response();
            List<object> News = new List<object>
            {
                title,
                message
            };
            response.Data = News;
            return Ok(response);
        }
    }
}
