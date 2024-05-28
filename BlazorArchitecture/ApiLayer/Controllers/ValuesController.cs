using ApiLayer.Token;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        public class Response
        {
            public bool IsOk { get; set; }
            public long ErrorCode { get; set; }
            public string ErrorMessage { get; set; } = string.Empty;
            public string[] ServerMessages { get; set; }  = new string[0];
            public object Data { get; set; } = new object();
        }

        public readonly IConfiguration _configuration;
        public readonly ITokenService _tokenService;

        public ValuesController(ITokenService tokenService, IConfiguration configuration)
        {
            _tokenService = tokenService;
            _configuration = configuration;
        }

        [NonAction]
        public string GetToken()
        {
            Token.Token token = new Token.Token();
            token = _tokenService.CreateToken(_configuration);
            return token.AccessToken;
        }

        [HttpPost]
        [ActionName("Login")]
        [AllowAnonymous]
        public async Task<string> Login(string userCode="", string password = "", string companyCode = "", string companyPassword = "", int userType = 0)
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["userCode"] = userCode;
            queryData["password"] = password;
            queryData["companyCode"] = companyCode;
            queryData["companyPassword"] = companyPassword;
            queryData["userType"] = userType;

            // API URL
            string apiUrl = "http://localhost:8080/api/Authentication/Login";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            var query = new List<string>();
            if (queryData == null || queryData.Count() < 0) return "";
            foreach (var kvp in queryData)
            {
                query.Add($"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value.ToString())}");
            }
            uriBuilder.Query = string.Join("&", query);

            // HttpClient nesnesi oluşturun
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsync(uriBuilder.Uri,null);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response!=null && response.IsOk)
                    {
                        return GetToken();
                    }
                    else
                    {
                        return "Kullanıcı bilgileri eksik veya hatalı !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

    }
}
