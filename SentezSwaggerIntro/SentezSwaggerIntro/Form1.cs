using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SentezSwaggerIntro.Models.ApiModels;

namespace SentezSwaggerIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fonk1();
        }

        public static string sessionId { get; set; } = string.Empty;
        public static string BoId { get; set; } = string.Empty;

        private async void button1_Click(object sender, EventArgs e)
        {
            sessionId = await LoginToApi();
            if (string.IsNullOrEmpty(sessionId)) return;
            richTextBox1.Text = sessionId;
            //await CheckSessionToApi();
            //await CheckSessionReConnectToApi();
            //await LogoutToApi();
            //await ChangePasswordToApi();
            //await SendSecureCodeToApi();
            //await EncryptPasswordToApi();
            //await ForgetPasswordToApi();
            //await UtilityQueryToApi();
            //await CreateBoToApi();
            //await InitBoToApi();
            //await GetByIdToApi();
            //await GetByRecIdToApi();
            //await PostBoToApi();
            //await UpdateBoToApi();
            //await FirstToApi();
            //await PreviousToApi();
            //await NextToApi();
            //await LastToApi();
            //await GetSchemaToApi();
            //await NewRecordToApi();
            //await DeleteRecordToApi();
            //await CancelRecordToApi();
            //await EditRecordToApi();
            //await PostDataToApi();
            //await GetFormListToApi();
            //await GetFormToApi();
            //await TableNewRowToApi();
            //await TableDeleteRowToApi();
            //await TableDeleteAllRowToApi();
            //await GetBOLookupsToApi();
            //await BOColumnChangeToApi();
            //await GetBOListToApi();
            //await GetBOTableNamesToApi();
            //await SetReceiptTypeBO();
            //await ParametersGetToApi();
            //await GetReportWithFilterToApi();
            //await ServiceManagementGetToApi();
            //await GetSessionsToApi();
            //await GetActiveUserToApi();
            //await GetActiveCompanyToApi();
            //await GetApplicationsToApi();
            //await GetUserRightsToApi();
            //await GetSecurityDefinitionToApi();
            //await ChangeLanguageToApi();
            //await LookupListToApi();
            //await GetFieldsToApi();
            //await GetExtensionFieldsToApi();
            //await SendMailToApi();
            //await UserMenuGetToApi();
            //await UserMenuFilterToApi();
            //await WindowSettingsGetToApi();
            //await WindowSettingsSaveWindowSettingToApi();
            //await CreateOperation();
            //await GetProducts();
            //await GetInventoryVariantTable(4292);
            //FindInventoryVariants();
        }

        //Token almanız için gerekli fonksiyon
        public static async Task<string> LoginToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["userCode"] = "Sentez";
            queryData["password"] = "1";
            queryData["companyCode"] = "10";
            //queryData["companyPassword"] = string.Empty;
            //queryData["userType"] = string.Empty;

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
                    HttpResponseMessage httpResponse = await client.PostAsync(uriBuilder.Uri, null);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return response.Data.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> CheckSessionToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["sessionId"] = sessionId;

            // API URL
            string apiUrl = "http://localhost:8080/api/Authentication/CheckSession";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsync(uriBuilder.Uri, null);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return response.Data.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> CheckSessionReConnectToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["sessionId"] = sessionId;
            queryData["userCode"] = "Sentez";
            queryData["password"] = "4521515";
            queryData["companyCode"] = "BIS-TEST";
            //queryData["companyPassword"] = string.Empty;
            //queryData["userType"] = string.Empty;

            // API URL
            string apiUrl = "http://localhost:8080/api/Authentication/CheckSessionReConnect";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsync(uriBuilder.Uri, null);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return response.Data.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> LogoutToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            //queryData["userType"] = 0;

            // API URL
            string apiUrl = "http://localhost:8080/api/Authentication/Logout";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "Logout İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> ChangePasswordToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["userCode"] = "Sentez";
            queryData["oldpassword"] = "kT3ZCX";
            queryData["new1password"] = "4521515";
            queryData["new2password"] = "4521515";
            //queryData["userType"] = 0;

            // API URL
            string apiUrl = "http://localhost:8080/api/Authentication/ChangePassword";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsync(uriBuilder.Uri, null);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "ChangePassword İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> SendSecureCodeToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["usercode"] = "Sentez";
            string subject = string.Empty;

            // API URL
            string apiUrl = "http://localhost:8080/api/Authentication/SendSecureCode";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, subject);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return response.Data.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> ForgetPasswordToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["usercode"] = "Sentez";
            queryData["subject"] = string.Empty;
            string content = string.Empty;

            // API URL
            string apiUrl = "http://localhost:8080/api/Authentication/ForgetPassword";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, content);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "ForgetPassword İşlemi Başarılı, Mail Adresinizi Kontrol Edin.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> EncryptPasswordToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["newPassword"] = "4521515";

            // API URL
            string apiUrl = "http://localhost:8080/api/Authentication/EncryptPassword";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsync(uriBuilder.Uri, null);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return response.Data.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //Select sorgularını çalıştırabileceğiniz fonksiyon
        public static async Task<object> UtilityQueryToApi()
        {
            SoDQueryModel soDQueryModel = new SoDQueryModel();
            soDQueryModel.Query = "select top 1 * from Erp_Inventory";

            // API endpoint URL
            string apiUrl = "http://localhost:8080/api/Utility/UtilityQuery";

            //Json Data
            string jsonData = JsonConvert.SerializeObject(soDQueryModel);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // HttpClient oluştur
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // İstek için HTTP içeriği oluştur
                    // POST isteği gönder
                    HttpResponseMessage httpResponse = await client.PostAsync(apiUrl, content);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<ExpandoObject> dTable = new List<ExpandoObject>();
                    if (response.IsOk)
                    {
                        //DataTable veya List<ExpandoObject> çevirebilirsiniz
                        return dTable = JsonConvert.DeserializeObject<List<ExpandoObject>>(response.Data.ToString());
                    }
                    else
                    {
                        return dTable = new List<ExpandoObject>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //BO modeli oluşturmanız gerekli fonksiyon
        public static async Task<string> CreateBoToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BOName"] = "OrderReceiptBO";
            //postData["initparams"] = string.Empty;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/CreateBO";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    // Başarılı bir yanıt alındıysa aşağıdaki işlemler gerçekleşir
                    if (response.IsOk)
                    {
                        return response.Data.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<string> InitBoToApi()
        {
            BoId = await CreateBoToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            //Bo'ya parametre geçirin isteğe bağlı
            //queryData["LogicalModuleId"] = 1;
            //queryData["Type"] = 1;
            //queryData["Type2"] = 1;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/InitBO";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    // Başarılı bir yanıt alındıysa aşağıdaki işlemler gerçekleşir
                    if (response.IsOk)
                    {
                        return response.Data.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //İstenilen kaydı getirme
        public static async Task<object> GetByIdToApi(long recId = 0)
        {
            BoId = await CreateBoToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["RecId"] = recId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/GetById";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetByRecIdToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoName"] = "InventoryBO";
            queryData["RecId"] = (long)104387;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/GetByRecId";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //Yeni Kayıt ve Güncelleme işlemlerinde kullanılacak fonksiyon
        public static async Task<object> PostBoToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BOName"] = "InventoryBO";

            //Bo'ya parametre geçirin isteğe bağlı
            //queryData["LogicalModuleId"] = 1;
            //queryData["Type"] = 1;
            //queryData["Type2"] = 1;

            Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
            List<ExpandoObject> dTable = new List<ExpandoObject>();
            ExpandoObject dRow = new ExpandoObject();
            (dRow as IDictionary<string, object>)["RecId"] = (long)117110;
            (dRow as IDictionary<string, object>)["InventoryCode"] = "AL3MP";
            (dRow as IDictionary<string, object>)["InventoryName"] = "Iphone 15";
            (dRow as IDictionary<string, object>)["InventoryType"] = "2";
            dTable.Add(dRow);

            dSet["Erp_Inventory"] = dTable;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/PostBO";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, dSet);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "PostBo İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> UpdateBoToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BOName"] = "InventoryBO";
            queryData["RecId"] = (long)104387;

            //Bo'ya parametre geçirin isteğe bağlı
            //queryData["LogicalModuleId"] = 1;
            //queryData["Type"] = 1;
            //queryData["Type2"] = 1;

            Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
            List<ExpandoObject> dTable = new List<ExpandoObject>();
            ExpandoObject dRow = new ExpandoObject();
            (dRow as IDictionary<string, object>)["RecId"] = (long)104387;
            (dRow as IDictionary<string, object>)["InventoryName"] = "Iphone 14";
            dTable.Add(dRow);
            dSet["Erp_Inventory"] = dTable;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/UpdateBO";

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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // PUT isteği gönderin
                    HttpResponseMessage httpResponse = await client.PutAsJsonAsync(uriBuilder.Uri, dSet);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "UpdateBo İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> FirstToApi()
        {
            await GetByIdToApi();

            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/First";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> PreviousToApi()
        {
            await GetByIdToApi();

            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/Previous";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> NextToApi()
        {
            await GetByIdToApi();

            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/Next";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> LastToApi()
        {
            await GetByIdToApi();

            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/Last";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetSchemaToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BOName"] = "InventoryBO";

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/GetSchema";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<BOColumn> dTable = new List<BOColumn>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dTable = JsonConvert.DeserializeObject<List<BOColumn>>(response.Data.ToString());
                    }
                    else
                    {
                        return dTable = new List<BOColumn>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> NewRecordToApi()
        {
            BoId = await CreateBoToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/NewRecord";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> DeleteRecordToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/DeleteRecord";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        return "DeleteRecord İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> CancelRecordToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/CancelRecord";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        return "CancelRecord İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> PostDataToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/PostData";

            PostDataModel postDataModel = new PostDataModel()
            {
                TableName = "Erp_Inventory",
                ChangeType = 0,
                RowId = 104387,
                ColumnName = "InventoryName",
                Value = "VOGUE"
            };
            PostDataModel postDataModel2 = new PostDataModel()
            {
                TableName = "Erp_Inventory",
                ChangeType = 0,
                RowId = 104387,
                ColumnName = "InventoryType",
                Value = "4"
            };
            PostDataModel[] postDataList = { postDataModel, postDataModel2 };
            string changes = JsonConvert.SerializeObject(postDataList);

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, changes);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> EditRecordToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["tableName"] = "Erp_Inventory";
            queryData["columnName"] = "InventoryName";
            queryData["recId"] = (long)104387;
            queryData["Value"] = "GAME GARAJ LAPTOP";

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/EditRecord";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "EditRecord İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetFormListToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BOName"] = "InventoryBO";
            queryData["FormName"] = "InventoryCardForm";
            //queryData["FormPolicyParamFieldName"] = "";
            queryData["Id"] = (long)104383;
            //queryData["EMails"] = "";

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/GetFormList";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetFormToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BOName"] = "InventoryBO";
            queryData["FormName"] = "InventoryCardForm";
            //queryData["FormPolicyParamFieldName"] = "";
            queryData["Id"] = (long)104383;
            //formu verdiğiniz mail adresine gönderir
            queryData["EMails"] = "orkan.koroglu@sentez.com";

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/GetForm";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> TableNewRowToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["TableName"] = "Erp_InventoryExplanation";

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/TableNewRow";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    ExpandoObject dRow = new ExpandoObject();
                    if (response.IsOk)
                    {
                        //DataRow veya ExpandoObject çevirebilirsiniz
                        return dRow = JsonConvert.DeserializeObject<ExpandoObject>(response.Data.ToString());
                    }
                    else
                    {
                        return dRow = new ExpandoObject();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> TableNewRowWithRelationToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["TableName"] = "Erp_InventorySerialCardItem";
            queryData["FieldName"] = "Explanation";
            queryData["ParentTableName"] = "Erp_InventorySerialCard";
            queryData["ParentRecId"] = (long)58;
            //Bu örnekte Erp_InventorySerialCardItem tablosu için ParentRecId alanı,
            //Erp_InventorySerialCard tablosunun RecId değerine karşılık gelmektedir.

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/TableNewRowWithRelation";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    ExpandoObject dRow = new ExpandoObject();
                    if (response.IsOk)
                    {
                        //DataRow veya ExpandoObject çevirebilirsiniz
                        return dRow = JsonConvert.DeserializeObject<ExpandoObject>(response.Data.ToString());
                    }
                    else
                    {
                        return dRow = new ExpandoObject();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> TableDeleteRowToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["TableName"] = "Erp_InventoryExplanation";
            queryData["recId"] = (long)104387;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/TableDeleteRow";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    ExpandoObject dRow = new ExpandoObject();
                    if (response.IsOk)
                    {
                        return "TableDeleteRow İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> TableDeleteAllRowToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["TableName"] = "Erp_InventoryExplanation";

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/TableDeleteAllRow";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsync(uriBuilder.Uri, null);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    ExpandoObject dRow = new ExpandoObject();
                    if (response.IsOk)
                    {
                        return "TableDeleteAllRow İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> ExtensionEnableToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["ExtensionName"] = "InventoryTotalServiceExtension";
            queryData["Enable"] = (bool)true;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/ExtensionEnable";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    ExpandoObject dRow = new ExpandoObject();
                    if (response.IsOk)
                    {
                        return "ExtensionEnable İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> AddExtensionToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["ExtensionName"] = "InventoryTotalServiceExtension";
            queryData["Enable"] = (bool)true;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/ExtensionEnable";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    ExpandoObject dRow = new ExpandoObject();
                    if (response.IsOk)
                    {
                        return "AddExtension İşlemi Başarılı.";
                    }
                    else
                    {
                        return "Hata Oluştu !";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetBOLookupsToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/GetBOLookups";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<BOLookups> bOLookups = new List<BOLookups>();
                    if (response.IsOk)
                    {
                        return bOLookups = JsonConvert.DeserializeObject<List<BOLookups>>(response.Data.ToString());
                    }
                    else
                    {
                        return bOLookups = new List<BOLookups>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> BOColumnChangeToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["tableName"] = "Erp_Inventory";
            queryData["columnName"] = "InventoryCode";
            queryData["recId"] = (long)104387;
            queryData["Value"] = JsonConvert.SerializeObject("VOGUE");

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/BOColumnChange";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetBOListToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/GetBOList";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return dSet = JsonConvert.DeserializeObject<Dictionary<string, List<ExpandoObject>>>(response.Data.ToString());
                    }
                    else
                    {
                        return dSet = new Dictionary<string, List<ExpandoObject>>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetBOTableNamesToApi()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/GetBOTableNames";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<string> TableList = new List<string>();
                    if (response.IsOk)
                    {
                        //DataSet veya Dictionary<string, List<ExpandoObject>> çevirebilirsiniz
                        return TableList = JsonConvert.DeserializeObject<List<string>>(response.Data.ToString());
                    }
                    else
                    {
                        return TableList = new List<string>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> SetReceiptTypeBO()
        {
            await GetByIdToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            queryData["LogicalModuleId"] = 1;
            queryData["Type"] = 1;
            queryData["Type2"] = 1;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/SetReceiptTypeBO";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return response.Data.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> ParametersGetToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["ParameterName"] = "InventoryParameters";
            queryData["PropertyName"] = "InventoryType";

            // API URL
            string apiUrl = "http://localhost:8080/api/Parameters/Get";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return string.Empty;
                        //response içindeki Data'ya bakarak gelen değikenlere göre modelleme yapıp Deserialize edebilirsiniz.
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetReportWithFilterToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            ReportParameter reportParameter = new ReportParameter()
            {
                ColumnSetName = "",
                DefName = "Standart",
                FilterSetName = "",
                PolicyParamFieldName = null,
                PolicyParamFormTagObj = null,
                PolicyParamRecordRecId = 0,
                PolicyParamWhereStr = null,
                ReportName = "InventoryListRpr",
                ReportType = 1
            };

            // API URL
            string apiUrl = "http://localhost:8080/api/Report/GetReportWithFilter";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, reportParameter);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return string.Empty;
                        //response içindeki Data'ya bakarak gelen değikenlere göre modelleme yapıp Deserialize edebilirsiniz.
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> ServiceManagementGetToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            SoDServiceModel soDServiceModel = new SoDServiceModel()
            {
                ServiceName = "StyleCardService",
                Params = new object[]
                {
                    (long)1,
                    (long)1,
                    (long)10
                }
            };

            // API URL
            string apiUrl = "http://localhost:8080/api/ServiceManagement/Execute";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, soDServiceModel);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "Servis çalıştı";
                        //response içindeki Data'ya bakarak gelen değikenlere göre modelleme yapıp Deserialize edebilirsiniz.
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetSessionsToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();

            // API URL
            string apiUrl = "http://localhost:8080/api/System/GetSessions";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<ExpandoObject> dTable = new List<ExpandoObject>();
                    if (response.IsOk)
                    {
                        //DataTable veya List<ExpandoObject> çevirebilirsiniz
                        return dTable = JsonConvert.DeserializeObject<List<ExpandoObject>>(response.Data.ToString());
                    }
                    else
                    {
                        return dTable = new List<ExpandoObject>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetActiveUserToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();

            // API URL
            string apiUrl = "http://localhost:8080/api/System/GetActiveUser";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    ExpandoObject dRow = new ExpandoObject();
                    if (response.IsOk)
                    {
                        //DataRow veya ExpandoObject çevirebilirsiniz
                        return dRow = JsonConvert.DeserializeObject<ExpandoObject>(response.Data.ToString());
                    }
                    else
                    {
                        return dRow = new ExpandoObject();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetActiveCompanyToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();

            // API URL
            string apiUrl = "http://localhost:8080/api/System/GetActiveCompany";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    ExpandoObject dRow = new ExpandoObject();
                    if (response.IsOk)
                    {
                        //DataRow veya ExpandoObject çevirebilirsiniz
                        return dRow = JsonConvert.DeserializeObject<ExpandoObject>(response.Data.ToString());
                    }
                    else
                    {
                        return dRow = new ExpandoObject();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetApplicationsToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();

            // API URL
            string apiUrl = "http://localhost:8080/api/System/GetApplications";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<string> aList = new List<string>();
                    if (response.IsOk)
                    {
                        return aList = JsonConvert.DeserializeObject<List<string>>(response.Data.ToString());
                    }
                    else
                    {
                        return aList = new List<string>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetUserRightsToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();

            // API URL
            string apiUrl = "http://localhost:8080/api/System/GetUserRights";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<ExpandoObject> dTable = new List<ExpandoObject>();
                    if (response.IsOk)
                    {
                        //DataTable veya List<ExpandoObject> çevirebilirsiniz
                        return dTable = JsonConvert.DeserializeObject<List<ExpandoObject>>(response.Data.ToString());
                    }
                    else
                    {
                        return dTable = new List<ExpandoObject>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetSecurityDefinitionToApi()
        {
            BoId = await CreateBoToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BoId"] = BoId;
            //CompanyId size göre değişecektir
            queryData["CompanyId"] = 10;

            // API URL
            string apiUrl = "http://localhost:8080/api/System/GetSecurityDefinition";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return string.Empty;
                        //response içindeki Data'ya bakarak gelen değikenlere göre modelleme yapıp Deserialize edebilirsiniz.
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> ChangeLanguageToApi()
        {
            BoId = await CreateBoToApi();
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["language"] = (long)LanguagePackages.Germanian;

            // API URL
            string apiUrl = "http://localhost:8080/api/System/ChangeLanguage";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return string.Empty;
                        //response içindeki Data'ya bakarak gelen değikenlere göre modelleme yapıp Deserialize edebilirsiniz.
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> LookupListToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["LookupName"] = "UnitList";

            // API URL
            string apiUrl = "http://localhost:8080/api/System/LookupList";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    LookupModel lookupModel = new LookupModel();
                    if (response.IsOk)
                    {
                        //Response içindeki Data'ya göre buradaki modeli değiştirebilirsiniz.
                        return lookupModel = JsonConvert.DeserializeObject<LookupModel>(response.Data.ToString());
                    }
                    else
                    {
                        return lookupModel = new LookupModel();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetFieldsToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["TableName"] = "Erp_Inventory";

            // API URL
            string apiUrl = "http://localhost:8080/api/System/GetFields";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<ExpandoObject> dTable = new List<ExpandoObject>();
                    if (response.IsOk)
                    {
                        //DataTable veya List<ExpandoObject> çevirebilirsiniz
                        return dTable = JsonConvert.DeserializeObject<List<ExpandoObject>>(response.Data.ToString());
                    }
                    else
                    {
                        return dTable = new List<ExpandoObject>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> GetExtensionFieldsToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["TableName"] = "Erp_Inventory";

            // API URL
            string apiUrl = "http://localhost:8080/api/System/GetExtensionFields";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<ExpandoObject> dTable = new List<ExpandoObject>();
                    if (response.IsOk)
                    {
                        //DataTable veya List<ExpandoObject> çevirebilirsiniz
                        return dTable = JsonConvert.DeserializeObject<List<ExpandoObject>>(response.Data.ToString());
                    }
                    else
                    {
                        return dTable = new List<ExpandoObject>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> SendMailToApi()
        {
            //Gönderici Adresi Sisteme Giriş Yapan Kullanıcının Mail Adresidir.
            IDictionary<string, object> queryData = new ExpandoObject();
            //Alıcı Mail Adresi
            queryData["receivers"] = "orkan.koroglu@sentez.com";
            //Mesaj Konusu
            queryData["subject"] = "Genel Duyuru";
            //Mesaj İçeriği
            string content = "SENTEZ YAZILIM";

            // API URL
            string apiUrl = "http://localhost:8080/api/System/SendMail";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, content);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "Mesaj Gönderildi";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> UserMenuGetToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();

            // API URL
            string apiUrl = "http://localhost:8080/api/UserMenu/Get";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        //Gelen Response'a Göre Data'yı Deserialize Yapabilirsiniz.
                        //Menü Listesi Dönüyor.
                        return "Kullanıcı Menü Listesi Yüklendi.";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> UserMenuFilterToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["menuname"] = "InventoryMenu";

            // API URL
            string apiUrl = "http://localhost:8080/api/UserMenu/Filter";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        //Gelen Response'a Göre Data'yı Deserialize Yapabilirsiniz.
                        //Menü Adına Göre Filtreleyip Menü Listesi Dönüyor.
                        return "Kullanıcı Menü Listesi Yüklendi.";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> WindowSettingsGetToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["UserId"] = (long)1;
            queryData["ProductCode"] = "0";
            queryData["ViewType"] = "0";
            queryData["WindowName"] = "OnDemand";
            queryData["ControlName"] = "ASServiceFaulty";
            queryData["PropertyName"] = "Erp_ASServiceFaulty";

            // API URL
            string apiUrl = "http://localhost:8080/api/WindowSettings/Get";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // GET isteği gönderin
                    HttpResponseMessage httpResponse = await client.GetAsync(uriBuilder.Uri);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<ExpandoObject> dTable = new List<ExpandoObject>();
                    if (response.IsOk)
                    {
                        //DataTable veya List<ExpandoObject> çevirebilirsiniz
                        return dTable = JsonConvert.DeserializeObject<List<ExpandoObject>>(response.Data.ToString());
                    }
                    else
                    {
                        return dTable = new List<ExpandoObject>();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static async Task<object> WindowSettingsSaveWindowSettingToApi()
        {
            IDictionary<string, object> queryData = new ExpandoObject();

            WindowSettingModel windowSettingModel = new WindowSettingModel()
            {
                UserId = 1,
                ProductCode = 0,
                Type = 0,
                WindowName = "OnDemand",
                ControlName = "ASService",
                PropertyName = "Erp_ASService",
                PropertyValue = "TEST"
            };

            // API URL
            string apiUrl = "http://localhost:8080/api/WindowSettings/SaveWindowSetting";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            if (queryData == null || queryData.Count() < 0) return "";
            var query = new List<string>();
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, windowSettingModel);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return "Meta_WindowSetting Tablosuna Kayıt Oluşturuldu";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        #region İnternet Satış

        ObservableCollection<ExpandoObject> MyCart; //Sepet
        public string Variant1TypeName;
        public string Variant2TypeName;
        public string Variant3TypeName;
        public string Variant4TypeName;
        public string Variant5TypeName;
        public string SelectedVariant1Name;
        public string SelectedVariant2Name;
        public string SelectedVariant3Name;
        public string SelectedVariant4Name;
        public string SelectedVariant5Name;
        public ExpandoObject SelectedProduct;
        public ExpandoObject SelectedVariant1;
        public ExpandoObject SelectedVariant2;
        public ExpandoObject SelectedVariant3;
        public ExpandoObject SelectedVariant4;
        public ExpandoObject SelectedVariant5;
        public List<ExpandoObject> Variants;
        public List<ExpandoObject> Variants1;
        public List<ExpandoObject> Variants2;
        public List<ExpandoObject> Variants3;
        public List<ExpandoObject> Variants4;
        public List<ExpandoObject> Variants5;

        // 1- ürünleri listeler (fiyat,ürün kodu,stok...)
        public async Task<List<ExpandoObject>> GetProducts()
        {
            SoDQueryModel soDQueryModel = new SoDQueryModel();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select i.RecId,i.InventoryCode,i.InventoryName ");
            sb.AppendLine(",isnull(IPL.Price,0) Price");
            sb.AppendLine(",(select top 1 ForexCode from Meta_Forex with(nolock) where RecId= IPL.ForexId) ForexCode");
            sb.AppendLine(",(select sum(ActualStock) from Erp_InventoryTotal with (nolock) where InventoryId = i.RecId) Quantity");
            sb.AppendLine(",(select top 1 UnitCode from Meta_UnitSetItem with (nolock) where RecId = (select top 1 UnitItemId from Erp_InventoryUnitItemSize with (nolock) where InventoryId = i.RecId and isnull(IsMainUnit,0)= 1)) Unit");
            sb.AppendLine(",(select top 1 Attachment from Erp_InventoryAttachment with (nolock) where InventoryId=i.RecId and Type in (1,8)) Image");
            sb.AppendLine(",i.CategoryId CategoryId,i.WebContent WebContent");
            sb.AppendLine(",i.HasVariant HasVariant");
            sb.AppendLine("from Erp_Inventory i with (nolock) ");
            sb.AppendLine("outer apply(select top 1 ipl.ForexId,ipl.Price");
            sb.AppendLine("from Erp_InventoryPriceList ipl with(nolock)");
            sb.AppendLine("where PriceType = 2 and isnull(ipl.IsPriceDiscount,1)= 1 and ipl.InventoryId = i.RecId");
            sb.AppendLine("and(StartDate <= getdate() or StartDate is null) and(EndDate >= getdate() or EndDate is null)");
            sb.AppendLine("order by ipl.Priority, ipl.StartDate desc, ipl.RecId desc) IPL");
            sb.AppendLine($"where isnull(i.IsPublishWeb,0)=1 and isnull(i.InUse,1)=1");
            sb.AppendLine("order by i.InventoryCode ");
            soDQueryModel.Query = sb.ToString();

            // API endpoint URL
            string apiUrl = "http://localhost:8080/api/Utility/UtilityQuery";

            //Json Data
            string jsonData = JsonConvert.SerializeObject(soDQueryModel);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // HttpClient oluştur
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // İstek için HTTP içeriği oluştur
                    // POST isteği gönder
                    HttpResponseMessage httpResponse = await client.PostAsync(apiUrl, content);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<ExpandoObject> dTable = new List<ExpandoObject>();
                    if (response.IsOk)
                    {
                        //DataTable veya List<ExpandoObject> çevirebilirsiniz
                        return dTable = JsonConvert.DeserializeObject<List<ExpandoObject>>(response.Data.ToString());
                    }
                    else
                    {
                        return dTable = new List<ExpandoObject>();
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        
        // seçilen ürünün varsa varyant matrisini getirir
        public async Task<List<ExpandoObject>> GetInventoryVariantTable(long inventoryId = 4292)
        {
            SoDQueryModel soDQueryModel = new SoDQueryModel();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select  distinct");
            sb.AppendLine("case when IV.Variant1Id is not null and card1.RecId=item1.CardId then card1.TypeId  else '' end Variant1TypeId,");
            sb.AppendLine("case when IV.Variant2Id is not null and card2.RecId=item2.CardId then card2.TypeId  else '' end Variant2TypeId,");
            sb.AppendLine("case when IV.Variant3Id is not null and card3.RecId=item3.CardId then card3.TypeId  else '' end Variant3TypeId,");
            sb.AppendLine("case when IV.Variant4Id is not null and card4.RecId=item4.CardId then card3.TypeId  else '' end Variant4TypeId,");
            sb.AppendLine("case when IV.Variant5Id is not null and card5.RecId=item5.CardId then card3.TypeId  else '' end Variant5TypeId,");
            sb.AppendLine("case when IV.Variant1TypeId is not null  and IV.Variant1TypeId=type1.RecId then type1.TypeName  else '' end Type1,");
            sb.AppendLine("type1.TypeUsage as Type1Usage,");
            sb.AppendLine("case when IV.Variant1Id is not null and IV.Variant1Id=item1.RecId then item1.RecId  else '' end Variant1RecId,");
            sb.AppendLine("case when IV.Variant1Id is not null and IV.Variant1Id=item1.RecId then item1.ItemCode  else '' end Variant1Code,");
            sb.AppendLine("case when IV.Variant1Id is not null and IV.Variant1Id=item1.RecId then item1.ItemName  else '' end Variant1Name,");
            sb.AppendLine("case when IV.Variant1Id is not null and IV.Variant1Id=item1.RecId then item1.ItemData  else '' end Variant1ItemData,");
            sb.AppendLine("case when IV.Variant2TypeId is not null  and IV.Variant2TypeId=type2.RecId then type2.TypeName  else '' end Type2,");
            sb.AppendLine("type2.TypeUsage as Type2Usage,");
            sb.AppendLine("case when IV.Variant2Id is not null and IV.Variant2Id=item2.RecId then item2.RecId  else '' end Variant2RecId,");
            sb.AppendLine("case when IV.Variant2Id is not null and IV.Variant2Id=item2.RecId then item2.ItemCode  else '' end Variant2Code,");
            sb.AppendLine("case when IV.Variant2Id is not null and IV.Variant2Id=item2.RecId then item2.ItemName  else '' end Variant2Name,");
            sb.AppendLine("case when IV.Variant2Id is not null and IV.Variant2Id=item2.RecId then item2.ItemData  else '' end Variant2ItemData,");
            sb.AppendLine("case when IV.Variant3TypeId is not null  and IV.Variant3TypeId=type3.RecId then type3.TypeName  else '' end Type3,");
            sb.AppendLine("type3.TypeUsage as Type3Usage,");
            sb.AppendLine("case when IV.Variant3Id is not null and IV.Variant3Id=item3.RecId then item3.RecId  else '' end Variant3RecId,");
            sb.AppendLine("case when IV.Variant3Id is not null and IV.Variant3Id=item3.RecId then item3.ItemCode  else '' end Variant3Code,");
            sb.AppendLine("case when IV.Variant3Id is not null and IV.Variant3Id=item3.RecId then item3.ItemName  else '' end Variant3Name,");
            sb.AppendLine("case when IV.Variant3Id is not null and IV.Variant3Id=item3.RecId then item3.ItemData  else '' end Variant3ItemData,");
            sb.AppendLine("case when IV.Variant4TypeId is not null and IV.Variant4TypeId=type4.RecId then type4.TypeName  else '' end Type4,");
            sb.AppendLine("type4.TypeUsage as Type4Usage,");
            sb.AppendLine("case when IV.Variant4Id is not null and IV.Variant4Id=item4.RecId then item4.RecId  else '' end Variant4RecId,");
            sb.AppendLine("case when IV.Variant4Id is not null and IV.Variant4Id=item4.RecId then item4.ItemCode  else '' end Variant4Code,");
            sb.AppendLine("case when IV.Variant4Id is not null and IV.Variant4Id=item4.RecId then item4.ItemName  else '' end Variant4Name,");
            sb.AppendLine("case when IV.Variant4Id is not null and IV.Variant4Id=item4.RecId then item4.ItemData  else '' end Variant4ItemData,");
            sb.AppendLine("case when IV.Variant5TypeId is not null  and IV.Variant5TypeId=type5.RecId then type5.TypeName  else '' end Type5,");
            sb.AppendLine("type5.TypeUsage as Type5Usage,");
            sb.AppendLine("case when IV.Variant5Id is not null and IV.Variant5Id=item5.RecId then item5.RecId  else '' end Variant5RecId,");
            sb.AppendLine("case when IV.Variant5Id is not null and IV.Variant5Id=item5.RecId then item5.ItemCode  else '' end Variant5Code,");
            sb.AppendLine("case when IV.Variant5Id is not null and IV.Variant5Id=item5.RecId then item5.ItemName  else '' end Variant5Name,");
            sb.AppendLine("case when IV.Variant5Id is not null and IV.Variant5Id=item5.RecId then item5.ItemData  else '' end Variant5ItemData,");
            sb.AppendLine("IV.RecId as InventoryVariantId,");
            sb.AppendLine("IV.Variant1Order as InventoryVariant1Order,");
            sb.AppendLine("IV.Variant2Order as InventoryVariant2Order,");
            sb.AppendLine("IV.Variant3Order as InventoryVariant3Order,");
            sb.AppendLine("IV.Variant4Order as InventoryVariant4Order,");
            sb.AppendLine("IV.Variant5Order as InventoryVariant5Order");
            sb.AppendLine("from Erp_InventoryVariant IV with (nolock)");
            sb.AppendLine("left join Erp_Inventory I with (nolock) on I.RecId=IV.InventoryId ");
            sb.AppendLine("left join Erp_VariantItem item1 with (nolock) on item1.RecId=IV.Variant1Id ");
            sb.AppendLine("left join Erp_VariantCard card1 with (nolock) on card1.RecId=item1.CardId");
            sb.AppendLine("left join Erp_VariantType type1 with (nolock) on type1.RecId=card1.TypeId");
            sb.AppendLine("left join Erp_VariantItem item2 with (nolock) on item2.RecId=IV.Variant2Id");
            sb.AppendLine("left join Erp_VariantCard card2 with (nolock) on card2.RecId=item2.CardId");
            sb.AppendLine("left join Erp_VariantType type2 with (nolock) on type2.RecId=card2.TypeId");
            sb.AppendLine("left join Erp_VariantItem item3 with (nolock) on item3.RecId=IV.Variant3Id");
            sb.AppendLine("left join Erp_VariantCard card3 with (nolock) on card3.RecId=item3.CardId");
            sb.AppendLine("left join Erp_VariantType type3 with (nolock) on type3.RecId=card3.TypeId");
            sb.AppendLine("left join Erp_VariantItem item4 with (nolock) on item4.RecId=IV.Variant4Id");
            sb.AppendLine("left join Erp_VariantCard card4 with (nolock) on card4.RecId=item4.CardId");
            sb.AppendLine("left join Erp_VariantType type4 with (nolock) on type4.RecId=card4.TypeId");
            sb.AppendLine("left join Erp_VariantItem item5 with (nolock) on item5.RecId=IV.Variant5Id");
            sb.AppendLine("left join Erp_VariantCard card5 with (nolock) on card5.RecId=item5.CardId");
            sb.AppendLine("left join Erp_VariantType type5 with (nolock) on type5.RecId=card5.TypeId");
            sb.AppendLine($"where IV.InventoryId={inventoryId} and IV.InUse=1");
            sb.AppendLine("order by IV.Variant1Order,IV.Variant2Order,IV.Variant3Order,IV.Variant4Order,IV.Variant5Order");
            soDQueryModel.Query = sb.ToString();

            // API endpoint URL
            string apiUrl = "http://localhost:8080/api/Utility/UtilityQuery";

            //Json Data
            string jsonData = JsonConvert.SerializeObject(soDQueryModel);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // HttpClient oluştur
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // İstek için HTTP içeriği oluştur
                    // POST isteği gönder
                    HttpResponseMessage httpResponse = await client.PostAsync(apiUrl, content);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    List<ExpandoObject> dTable = new List<ExpandoObject>();
                    if (response.IsOk)
                    {
                        //DataTable veya List<ExpandoObject> çevirebilirsiniz
                        return Variants = JsonConvert.DeserializeObject<List<ExpandoObject>>(response.Data.ToString());
                    }
                    else
                    {
                        return Variants = new List<ExpandoObject>();
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        // varyant lisetesini gruplara ayırarak kullanıcıya seçim yaptırabilirsiniz.
        public void FindInventoryVariants()
        {
            SelectedVariant1 = null;
            SelectedVariant2 = null;
            SelectedVariant3 = null;
            SelectedVariant4 = null;
            SelectedVariant5 = null;
            Variant1TypeName = string.Empty;
            Variant2TypeName = string.Empty;
            Variant3TypeName = string.Empty;
            Variant4TypeName = string.Empty;
            Variant5TypeName = string.Empty;
            Variants1 = new List<ExpandoObject>();
            Variants2 = new List<ExpandoObject>();
            Variants3 = new List<ExpandoObject>();
            Variants4 = new List<ExpandoObject>();
            Variants5 = new List<ExpandoObject>();
            if (Variants == null || Variants.Count < 1) return;
            foreach (var item in Variants)
            {
                IDictionary<string, object> itemW = item as IDictionary<string, object>;
                if (itemW != null && itemW.ContainsKey("Variant1RecId") && itemW["Variant1RecId"] != null && Convert.ToInt64(itemW["Variant1RecId"]) != 0)
                {
                    if (!Variants1.Any(x => (x as IDictionary<string, object>) != null && (x as IDictionary<string, object>).ContainsKey("RecId") && (x as IDictionary<string, object>)["RecId"].Equals(itemW["Variant1RecId"])))
                    {
                        ExpandoObject exp = new ExpandoObject();
                        if (itemW.ContainsKey("Variant1RecId") && itemW["Variant1RecId"] != null) (exp as IDictionary<string, object>).Add("RecId", itemW["Variant1RecId"]);
                        if (itemW.ContainsKey("Variant1Code") && itemW["Variant1Code"] != null) (exp as IDictionary<string, object>).Add("ItemCode", itemW["Variant1Code"]);
                        if (itemW.ContainsKey("Variant1Name") && itemW["Variant1Name"] != null) (exp as IDictionary<string, object>).Add("ItemName", itemW["Variant1Name"]);
                        if (itemW.ContainsKey("Variant1ItemData") && itemW["Variant1ItemData"] != null) (exp as IDictionary<string, object>).Add("ItemData", itemW["Variant1ItemData"]);
                        if (itemW != null && itemW.ContainsKey("Type1") && itemW["Type1"] != null) Variant1TypeName = itemW["Type1"].ToString();
                        Variants1.Add(exp);
                    }
                }
                if (itemW != null && itemW.ContainsKey("Variant2RecId") && itemW["Variant2RecId"] != null && Convert.ToInt64(itemW["Variant2RecId"]) != 0)
                {
                    if (!Variants2.Any(x => (x as IDictionary<string, object>) != null && (x as IDictionary<string, object>).ContainsKey("RecId") && (x as IDictionary<string, object>)["RecId"].Equals(itemW["Variant2RecId"])))
                    {
                        ExpandoObject exp = new ExpandoObject();
                        if (itemW.ContainsKey("Variant2RecId") && itemW["Variant2RecId"] != null) (exp as IDictionary<string, object>).Add("RecId", itemW["Variant2RecId"]);
                        if (itemW.ContainsKey("Variant2Code") && itemW["Variant2Code"] != null) (exp as IDictionary<string, object>).Add("ItemCode", itemW["Variant2Code"]);
                        if (itemW.ContainsKey("Variant2Name") && itemW["Variant2Name"] != null) (exp as IDictionary<string, object>).Add("ItemName", itemW["Variant2Name"]);
                        if (itemW.ContainsKey("Variant2ItemData") && itemW["Variant2ItemData"] != null) (exp as IDictionary<string, object>).Add("ItemData", itemW["Variant2ItemData"]);
                        if (itemW != null && itemW.ContainsKey("Type2") && itemW["Type2"] != null) Variant2TypeName = itemW["Type2"].ToString();
                        Variants2.Add(exp);
                    }
                }
                if (itemW != null && itemW.ContainsKey("Variant3RecId") && itemW["Variant3RecId"] != null && Convert.ToInt64(itemW["Variant3RecId"]) != 0)
                {
                    if (!Variants3.Any(x => (x as IDictionary<string, object>) != null && (x as IDictionary<string, object>).ContainsKey("RecId") && (x as IDictionary<string, object>)["RecId"].Equals(itemW["Variant3RecId"])))
                    {
                        ExpandoObject exp = new ExpandoObject();
                        if (itemW.ContainsKey("Variant3RecId") && itemW["Variant3RecId"] != null) (exp as IDictionary<string, object>).Add("RecId", itemW["Variant3RecId"]);
                        if (itemW.ContainsKey("Variant3Code") && itemW["Variant3Code"] != null) (exp as IDictionary<string, object>).Add("ItemCode", itemW["Variant3Code"]);
                        if (itemW.ContainsKey("Variant3Name") && itemW["Variant4Name"] != null) (exp as IDictionary<string, object>).Add("ItemName", itemW["Variant3Name"]);
                        if (itemW.ContainsKey("Variant3ItemData") && itemW["Variant3ItemData"] != null) (exp as IDictionary<string, object>).Add("ItemData", itemW["Variant3ItemData"]);
                        if (itemW != null && itemW.ContainsKey("Type3") && itemW["Type3"] != null) Variant3TypeName = itemW["Type3"].ToString();
                        Variants3.Add(exp);
                    }
                }
                if (itemW != null && itemW.ContainsKey("Variant4RecId") && itemW["Variant4RecId"] != null && Convert.ToInt64(itemW["Variant4RecId"]) != 0)
                {
                    if (!Variants4.Any(x => (x as IDictionary<string, object>) != null && (x as IDictionary<string, object>).ContainsKey("RecId") && (x as IDictionary<string, object>)["RecId"].Equals(itemW["Variant4RecId"])))
                    {
                        ExpandoObject exp = new ExpandoObject();
                        if (itemW.ContainsKey("Variant4RecId") && itemW["Variant4RecId"] != null) (exp as IDictionary<string, object>).Add("RecId", itemW["Variant4RecId"]);
                        if (itemW.ContainsKey("Variant4Code") && itemW["Variant4Code"] != null) (exp as IDictionary<string, object>).Add("ItemCode", itemW["Variant4Code"]);
                        if (itemW.ContainsKey("Variant4Name") && itemW["Variant4Name"] != null) (exp as IDictionary<string, object>).Add("ItemName", itemW["Variant4Name"]);
                        if (itemW.ContainsKey("Variant4ItemData") && itemW["Variant4ItemData"] != null) (exp as IDictionary<string, object>).Add("ItemData", itemW["Variant4ItemData"]);
                        if (itemW != null && itemW.ContainsKey("Type4") && itemW["Type4"] != null) Variant4TypeName = itemW["Type4"].ToString();
                        Variants4.Add(exp);
                    }
                }
                if (itemW != null && itemW.ContainsKey("Variant5RecId") && itemW["Variant5RecId"] != null && Convert.ToInt64(itemW["Variant5RecId"]) != 0)
                {
                    if (!Variants5.Any(x => (x as IDictionary<string, object>) != null && (x as IDictionary<string, object>).ContainsKey("RecId") && (x as IDictionary<string, object>)["RecId"].Equals(itemW["Variant5RecId"])))
                    {
                        ExpandoObject exp = new ExpandoObject();
                        if (itemW.ContainsKey("Variant5RecId") && itemW["Variant5RecId"] != null) (exp as IDictionary<string, object>).Add("RecId", itemW["Variant5RecId"]);
                        if (itemW.ContainsKey("Variant5Code") && itemW["Variant5Code"] != null) (exp as IDictionary<string, object>).Add("ItemCode", itemW["Variant5Code"]);
                        if (itemW.ContainsKey("Variant5Name") && itemW["Variant5Name"] != null) (exp as IDictionary<string, object>).Add("ItemName", itemW["Variant5Name"]);
                        if (itemW.ContainsKey("Variant5ItemData") && itemW["Variant5ItemData"] != null) (exp as IDictionary<string, object>).Add("ItemData", itemW["Variant5ItemData"]);
                        if (itemW != null && itemW.ContainsKey("Type5") && itemW["Type5"] != null) Variant5TypeName = itemW["Type5"].ToString();
                        Variants5.Add(exp);
                    }
                }
            }
        }

        // 2- sepete ekleme
        public async Task AddToCart(ExpandoObject product)
        {
            long inventoryVariantId = 0;
            var productW = product as IDictionary<string, object>;
            bool hasVariant = false;
            if (productW != null && productW.ContainsKey("HasVariant") && productW["HasVariant"] != null) hasVariant = Convert.ToBoolean(productW["HasVariant"]);
            if (hasVariant)
            {
                long inventoryId = 0;
                if (productW != null && productW.ContainsKey("RecId") && productW["RecId"] != null) long.TryParse(productW["RecId"].ToString(), out inventoryId);
                Variants = await GetInventoryVariantTable(inventoryId);
                FindInventoryVariants();
                SelectedProduct = product;
                // Burada bir ekran açıp kullanıcıya varyantlı seçim yaptırmanız gerekiyor,
                // Kullanıcıya varyant seçimi yaptırdıktan sonra,
                // AddToCartVariant() metoduna yönlendirebilirsiniz.
            }
            else
            {
                await AddToCart(product, inventoryVariantId);
            }

        }

        // varyantları seçtikten sonra sepete ekleme öncesinde yukarıdaki fonksiyonu çağırmalısnız
        public async Task AddToCartVariant(ExpandoObject product, ExpandoObject v1, ExpandoObject v2, ExpandoObject v3, ExpandoObject v4, ExpandoObject v5)
        {
            long inventoryVariantId = 0;
            var productW = product as IDictionary<string, object>;
            if (SelectedVariant1 != null && SelectedVariant2 != null && SelectedVariant3 != null && SelectedVariant4 != null && SelectedVariant5 != null)
            {
                long v1Id = 0, v2Id = 0, v3Id = 0, v4Id = 0, v5Id = 0;
                var variant1W = SelectedVariant1 as IDictionary<string, object>;
                if (variant1W != null && variant1W.ContainsKey("RecId") && variant1W["RecId"] != null) long.TryParse(variant1W["RecId"].ToString(), out v1Id);
                var variant2W = SelectedVariant2 as IDictionary<string, object>;
                if (variant2W != null && variant2W.ContainsKey("RecId") && variant2W["RecId"] != null) long.TryParse(variant2W["RecId"].ToString(), out v2Id);
                var variant3W = SelectedVariant3 as IDictionary<string, object>;
                if (variant3W != null && variant3W.ContainsKey("RecId") && variant3W["RecId"] != null) long.TryParse(variant3W["RecId"].ToString(), out v3Id);
                var variant4W = SelectedVariant4 as IDictionary<string, object>;
                if (variant4W != null && variant4W.ContainsKey("RecId") && variant4W["RecId"] != null) long.TryParse(variant4W["RecId"].ToString(), out v4Id);
                var variant5W = SelectedVariant5 as IDictionary<string, object>;
                if (variant5W != null && variant5W.ContainsKey("RecId") && variant5W["RecId"] != null) long.TryParse(variant5W["RecId"].ToString(), out v5Id);
                var qcitems = Variants.Where(x => (x as IDictionary<string, object>) != null
                 && (x as IDictionary<string, object>).ContainsKey("Variant1RecId") && (x as IDictionary<string, object>)["Variant1RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant1RecId"]) == v1Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant2RecId") && (x as IDictionary<string, object>)["Variant2RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant2RecId"]) == v2Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant3RecId") && (x as IDictionary<string, object>)["Variant3RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant3RecId"]) == v3Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant4RecId") && (x as IDictionary<string, object>)["Variant4RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant4RecId"]) == v4Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant5RecId") && (x as IDictionary<string, object>)["Variant5RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant5RecId"]) == v5Id);
                if (qcitems != null && qcitems.Count() > 0)
                {
                    var qcitemW = qcitems.First() as IDictionary<string, object>;
                    if (qcitemW != null && qcitemW.ContainsKey("InventoryVariantId") && qcitemW["InventoryVariantId"] != null) long.TryParse(qcitemW["InventoryVariantId"].ToString(), out inventoryVariantId);
                }
            }
            if (SelectedVariant1 != null && SelectedVariant2 != null && SelectedVariant3 != null && SelectedVariant4 != null && SelectedVariant5 == null)
            {
                long v1Id = 0, v2Id = 0, v3Id = 0, v4Id = 0;
                var variant1W = SelectedVariant1 as IDictionary<string, object>;
                if (variant1W != null && variant1W.ContainsKey("RecId") && variant1W["RecId"] != null) long.TryParse(variant1W["RecId"].ToString(), out v1Id);
                var variant2W = SelectedVariant2 as IDictionary<string, object>;
                if (variant2W != null && variant2W.ContainsKey("RecId") && variant2W["RecId"] != null) long.TryParse(variant2W["RecId"].ToString(), out v2Id);
                var variant3W = SelectedVariant3 as IDictionary<string, object>;
                if (variant3W != null && variant3W.ContainsKey("RecId") && variant3W["RecId"] != null) long.TryParse(variant3W["RecId"].ToString(), out v3Id);
                var variant4W = SelectedVariant4 as IDictionary<string, object>;
                if (variant4W != null && variant4W.ContainsKey("RecId") && variant4W["RecId"] != null) long.TryParse(variant4W["RecId"].ToString(), out v4Id);
                var qcitems = Variants.Where(x => (x as IDictionary<string, object>) != null
                 && (x as IDictionary<string, object>).ContainsKey("Variant1RecId") && (x as IDictionary<string, object>)["Variant1RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant1RecId"]) == v1Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant2RecId") && (x as IDictionary<string, object>)["Variant2RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant2RecId"]) == v2Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant3RecId") && (x as IDictionary<string, object>)["Variant3RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant3RecId"]) == v3Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant4RecId") && (x as IDictionary<string, object>)["Variant4RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant4RecId"]) == v4Id);
                if (qcitems != null && qcitems.Count() > 0)
                {
                    var qcitemW = qcitems.First() as IDictionary<string, object>;
                    if (qcitemW != null && qcitemW.ContainsKey("InventoryVariantId") && qcitemW["InventoryVariantId"] != null) long.TryParse(qcitemW["InventoryVariantId"].ToString(), out inventoryVariantId);
                }
            }
            else if (SelectedVariant1 != null && SelectedVariant2 != null && SelectedVariant3 != null && SelectedVariant4 == null)
            {
                long v1Id = 0, v2Id = 0, v3Id = 0;
                var variant1W = SelectedVariant1 as IDictionary<string, object>;
                if (variant1W != null && variant1W.ContainsKey("RecId") && variant1W["RecId"] != null) long.TryParse(variant1W["RecId"].ToString(), out v1Id);
                var variant2W = SelectedVariant2 as IDictionary<string, object>;
                if (variant2W != null && variant2W.ContainsKey("RecId") && variant2W["RecId"] != null) long.TryParse(variant2W["RecId"].ToString(), out v2Id);
                var variant3W = SelectedVariant3 as IDictionary<string, object>;
                if (variant3W != null && variant3W.ContainsKey("RecId") && variant3W["RecId"] != null) long.TryParse(variant3W["RecId"].ToString(), out v3Id);
                var qcitems = Variants.Where(x => (x as IDictionary<string, object>) != null
                 && (x as IDictionary<string, object>).ContainsKey("Variant1RecId") && (x as IDictionary<string, object>)["Variant1RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant1RecId"]) == v1Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant2RecId") && (x as IDictionary<string, object>)["Variant2RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant2RecId"]) == v2Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant3RecId") && (x as IDictionary<string, object>)["Variant3RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant3RecId"]) == v3Id);
                if (qcitems != null && qcitems.Count() > 0)
                {
                    var qcitemW = qcitems.First() as IDictionary<string, object>;
                    if (qcitemW != null && qcitemW.ContainsKey("InventoryVariantId") && qcitemW["InventoryVariantId"] != null) long.TryParse(qcitemW["InventoryVariantId"].ToString(), out inventoryVariantId);
                }
            }
            else if (SelectedVariant1 != null && SelectedVariant2 != null && SelectedVariant3 == null)
            {
                long v1Id = 0, v2Id = 0;
                var variant1W = SelectedVariant1 as IDictionary<string, object>;
                if (variant1W != null && variant1W.ContainsKey("RecId") && variant1W["RecId"] != null) long.TryParse(variant1W["RecId"].ToString(), out v1Id);
                var variant2W = SelectedVariant2 as IDictionary<string, object>;
                if (variant2W != null && variant2W.ContainsKey("RecId") && variant2W["RecId"] != null) long.TryParse(variant2W["RecId"].ToString(), out v2Id);
                var qcitems = Variants.Where(x => (x as IDictionary<string, object>) != null
                 && (x as IDictionary<string, object>).ContainsKey("Variant1RecId") && (x as IDictionary<string, object>)["Variant1RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant1RecId"]) == v1Id
                 && (x as IDictionary<string, object>).ContainsKey("Variant2RecId") && (x as IDictionary<string, object>)["Variant2RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant2RecId"]) == v2Id);
                if (qcitems != null && qcitems.Count() > 0)
                {
                    var qcitemW = qcitems.First() as IDictionary<string, object>;
                    if (qcitemW != null && qcitemW.ContainsKey("InventoryVariantId") && qcitemW["InventoryVariantId"] != null) long.TryParse(qcitemW["InventoryVariantId"].ToString(), out inventoryVariantId);
                }
            }
            else if (SelectedVariant1 != null && SelectedVariant2 == null)
            {
                long v1Id = 0;
                var variant1W = SelectedVariant1 as IDictionary<string, object>;
                if (variant1W != null && variant1W.ContainsKey("RecId") && variant1W["RecId"] != null) long.TryParse(variant1W["RecId"].ToString(), out v1Id);
                var qcitems = Variants.Where(x => (x as IDictionary<string, object>) != null
                 && (x as IDictionary<string, object>).ContainsKey("Variant1RecId") && (x as IDictionary<string, object>)["Variant1RecId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["Variant1RecId"]) == v1Id);
                if (qcitems != null && qcitems.Count() > 0)
                {
                    var qcitemW = qcitems.First() as IDictionary<string, object>;
                    if (qcitemW != null && qcitemW.ContainsKey("InventoryVariantId") && qcitemW["InventoryVariantId"] != null) long.TryParse(qcitemW["InventoryVariantId"].ToString(), out inventoryVariantId);
                }
            }

            if (inventoryVariantId > 0)
            {
                await AddToCart(product, inventoryVariantId);
            }
        }

        //tüm işlemler yapıldıktan sonra, son sepete ekleme fonksiyonudur. Diğer fonksiyonlar bu fonksiyonu kullanıyor
        public async Task AddToCart(ExpandoObject product, long ivId)
        {
            try
            {
                if (MyCart == null) MyCart = new ObservableCollection<ExpandoObject>();

                var productW = product as IDictionary<string, object>;
                long inventoryId = 0;
                if (productW != null && productW.ContainsKey("RecId") && productW["RecId"] != null) long.TryParse(productW["RecId"].ToString(), out inventoryId);
                if (inventoryId < 1)
                {
                    return;
                }
                bool hasVariant = false;
                if (productW != null && productW.ContainsKey("HasVariant") && productW["HasVariant"] != null) hasVariant = Convert.ToBoolean(productW["HasVariant"]);
                if (hasVariant && ivId < 1)
                {
                    return;
                }
                IEnumerable<ExpandoObject> cartItem = null;
                cartItem = MyCart.Where(x => (x as IDictionary<string, object>) != null
                                && (x as IDictionary<string, object>).ContainsKey("InventoryId") && (x as IDictionary<string, object>)["InventoryId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["InventoryId"]) == inventoryId
                    && (x as IDictionary<string, object>).ContainsKey("InventoryVariantId") && (x as IDictionary<string, object>)["InventoryVariantId"] != null && Convert.ToInt64((x as IDictionary<string, object>)["InventoryVariantId"]) == ivId);
                if (cartItem == null || cartItem.Count() < 1)
                {
                    var newItem = new ExpandoObject();
                    var newItemW = newItem as IDictionary<string, object>;
                    newItemW.Add("ItemType", 1);
                    newItemW.Add("InventoryId", productW["RecId"]);
                    if (ivId > 0)
                    {
                        newItemW.Add("InventoryVariantId", ivId);
                        newItemW.Add("Variant1TypeName", SelectedVariant1Name);
                        newItemW.Add("Variant2TypeName", SelectedVariant2Name);
                        newItemW.Add("Variant3TypeName", SelectedVariant3Name);
                        newItemW.Add("Variant4TypeName", SelectedVariant4Name);
                        newItemW.Add("Variant5TypeName", SelectedVariant5Name);
                    }
                    else
                    {
                        newItemW.Add("InventoryVariantId", 0);
                    }
                    newItemW.Add("Quantity", 1);
                    newItemW.Add("Price", productW["Price"]);
                    //MyCart içini açıp CreateOrder() metotunu bu şekilde daha kolay kullanabilirsiniz.
                    MyCart.Add(newItem);
                }
                else
                {
                    var firstRow = cartItem.FirstOrDefault();
                    if (firstRow != null)
                    {
                        var firstRowW = firstRow as IDictionary<string, object>;
                        decimal Qty = 0;
                        if (firstRowW != null && firstRowW.ContainsKey("Quantity") && firstRowW["Quantity"] != null) decimal.TryParse(firstRowW["Quantity"].ToString(), out Qty);
                        if (firstRowW != null && firstRowW.ContainsKey("Quantity") && firstRowW["Quantity"] != null) firstRowW["Quantity"] = Qty + 1;
                    }
                }
            }
            finally
            {
                SelectedProduct = null;
            }
        }

        //sipariş oluşturma
        public async Task<object> CreateOperation()
        {
            IDictionary<string, object> queryData = new ExpandoObject();
            queryData["BOName"] = "OrderReceiptBO";

            //Bo'ya parametre geçirin isteğe bağlı
            //queryData["LogicalModuleId"] = 1;
            queryData["Type"] = 2;
            //queryData["Type2"] = 1;

            Dictionary<string, List<ExpandoObject>> dSet = new Dictionary<string, List<ExpandoObject>>();
            
            List<ExpandoObject> dTable = new List<ExpandoObject>();
            ExpandoObject dRow = new ExpandoObject();
            (dRow as IDictionary<string, object>)["RecId"] = (long)-1;
            (dRow as IDictionary<string, object>)["CurrentAccountId"] = (long)2;
            (dRow as IDictionary<string, object>)["WarehouseId"] = (long)54;
            (dRow as IDictionary<string, object>)["IsApproved"] = (long)0;
            dTable.Add(dRow);
            dSet["Erp_OrderReceipt"] = dTable;

            List<ExpandoObject> dTable2 = new List<ExpandoObject>();
            ExpandoObject dRow2 = new ExpandoObject();
            (dRow2 as IDictionary<string, object>)["RecId"] = (long)-1;
            (dRow2 as IDictionary<string, object>)["Explanation"] = Guid.NewGuid().ToString();
            (dRow2 as IDictionary<string, object>)["ReceiptType"] = (long)2;
            (dRow2 as IDictionary<string, object>)["OrderReceiptId"] = (long)-1;
            (dRow2 as IDictionary<string, object>)["ItemType"] = (long)1;
            (dRow2 as IDictionary<string, object>)["InventoryId"] = (long)4392;
            (dRow2 as IDictionary<string, object>)["UnitId"] = (long)24;
            (dRow2 as IDictionary<string, object>)["UnitPrice"] = (long)10;
            //(dRow as IDictionary<string, object>)["Quantity"] = "5";
            dTable2.Add(dRow2);

            ExpandoObject dRow2_1 = new ExpandoObject();
            (dRow2_1 as IDictionary<string, object>)["RecId"] = (long)-2;
            (dRow2_1 as IDictionary<string, object>)["Explanation"] = Guid.NewGuid().ToString();
            (dRow2_1 as IDictionary<string, object>)["ReceiptType"] = (long)2;
            (dRow2_1 as IDictionary<string, object>)["OrderReceiptId"] = (long)-1;
            (dRow2_1 as IDictionary<string, object>)["ItemType"] = (long)1;
            (dRow2_1 as IDictionary<string, object>)["InventoryId"] = (long)4292;
            (dRow2_1 as IDictionary<string, object>)["UnitId"] = (long)24;
            (dRow2_1 as IDictionary<string, object>)["UnitPrice"] = (long)10;
            //(dRow2_1 as IDictionary<string, object>)["Quantity"] = "7";
            dTable2.Add(dRow2_1);
            dSet["Erp_OrderReceiptItem"] = dTable2;

            List<ExpandoObject> dTable3 = new List<ExpandoObject>();
            ExpandoObject dRow3 = new ExpandoObject();
            (dRow3 as IDictionary<string, object>)["RecId"] = (long)-1;
            (dRow3 as IDictionary<string, object>)["OrderReceiptItemId"] = (long)-1;
            (dRow3 as IDictionary<string, object>)["InventoryId"] = (long)4392;
            (dRow3 as IDictionary<string, object>)["InventoryVariantId"] = (long)9698;
            (dRow3 as IDictionary<string, object>)["Quantity"] = (long)1;
            dTable3.Add(dRow3);

            ExpandoObject dRow3_1 = new ExpandoObject();
            (dRow3_1 as IDictionary<string, object>)["RecId"] = (long)-2;
            (dRow3_1 as IDictionary<string, object>)["OrderReceiptItemId"] = (long)-2;
            (dRow3_1 as IDictionary<string, object>)["InventoryId"] = (long)4292;
            (dRow3_1 as IDictionary<string, object>)["InventoryVariantId"] = (long)322;
            (dRow3_1 as IDictionary<string, object>)["Quantity"] = (long)1;
            dTable3.Add(dRow3_1);
            dSet["Erp_OrderReceiptItemVariant"] = dTable3;

            // API URL
            string apiUrl = "http://localhost:8080/api/BO/PostBO";

            // UriBuilder kullanarak güvenli URL oluşturun
            UriBuilder uriBuilder = new UriBuilder(apiUrl);
            var query = new List<string>();
            if (queryData == null || queryData.Count() < 0) return 0;
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
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessionId);
                    // POST isteği gönderin
                    HttpResponseMessage httpResponse = await client.PostAsJsonAsync(uriBuilder.Uri, dSet);
                    Response response = await httpResponse.Content.ReadFromJsonAsync<Response>();
                    if (response.IsOk)
                    {
                        return JsonConvert.DeserializeObject<long>(response.Data.ToString());
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        #endregion
    
    }
}