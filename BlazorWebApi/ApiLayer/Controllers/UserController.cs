using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;

namespace ApiLayer.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [ActionName("GetUsers")]
        public IActionResult GetUsers()
        {
            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionString"]))
            {
                // Bağlantıyı aç
                connection.Open();

                // Veritabanından veri almak için kullanılacak sorgu
                string query = "select * from Meta_User";

                // SQL komutunu ve bağlantıyı oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Veri okuyucuyu oluştur
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // DataTable oluştur
                        DataTable userData = new DataTable();

                        // Veri okuyucudan gelen sütunları DataTable'a ekle
                        userData.Load(reader);

                        string jsonData = JsonConvert.SerializeObject(userData);
                        return Ok(jsonData);
                    }
                }
            }
        }

        [HttpGet]
        [ActionName("GetUser")]
        public IActionResult GetUser([FromQuery] long RecId)
        {
            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionString"]))
            {
                // Bağlantıyı aç
                connection.Open();

                // Veritabanından veri almak için kullanılacak sorgu
                string query = $"select * from Meta_User where RecId = {RecId}";

                // SQL komutunu ve bağlantıyı oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Veri okuyucuyu oluştur
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // DataTable oluştur
                        DataTable userData = new DataTable();

                        // Veri okuyucudan gelen sütunları DataTable'a ekle
                        userData.Load(reader);

                        string jsonData = JsonConvert.SerializeObject(userData);
                        return Ok(jsonData);
                    }
                }
            }
        }

        [HttpDelete]
        [ActionName("DeleteUser")]
        public IActionResult DeleteUser([FromQuery] long RecId)
        {
            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionString"]))
            {
                // Bağlantıyı aç
                connection.Open();

                // Veritabanından veri almak için kullanılacak sorgu
                string query = $"delete from Meta_User where RecId = @RecId";

                // SQL komutunu ve bağlantıyı oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleyerek SQL enjeksiyonundan korunma
                    command.Parameters.AddWithValue("@RecId", RecId);

                    // Komutu çalıştır ve etkilenen satır sayısını al
                    int rowsAffected = command.ExecuteNonQuery();

                    // Eğer hiç satır etkilenmediyse, silme işlemi başarısızdır
                    if (rowsAffected == 0)
                    {
                        return Ok("Silmek istediğiniz çalışan bulunamadı.");
                    }
                    else
                    {
                        return Ok("Çalışan başarıyla silindi.");
                    }
                }
            }
        }

        [HttpPost]
        [ActionName("AddUser")]
        public IActionResult AddUser([FromBody] Dictionary<string, object> User)
        {
            User.Add("UserCode", "Orkan");
            User.Add("UserName", "Köroğlu");

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionString"]))
            {
                // Bağlantıyı aç
                connection.Open();

                // Veritabanından veri almak için kullanılacak sorgu
                string query = $"insert into Meta_User(UserCode,UserName) values (@UserCode,@UserName)";

                // SQL komutunu ve bağlantıyı oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleyerek SQL enjeksiyonundan korunma
                    command.Parameters.AddWithValue("@UserCode", User["UserCode"]);
                    command.Parameters.AddWithValue("@UserName", User["UserName"]);

                    // Komutu çalıştır ve etkilenen satır sayısını al
                    int rowsAffected = command.ExecuteNonQuery();

                    // Eğer hiç satır etkilenmediyse, silme işlemi başarısızdır
                    if (rowsAffected == 0)
                    {
                        return Ok("Ekleme işlemi başarısız oldu.");
                    }
                    else
                    {
                        return Ok("Ekleme başarılı oldu.");
                    }
                }
            }
        }

        [HttpPut]
        [ActionName("UpdateUser")]
        public IActionResult UpdateUser([FromBody] Dictionary<string, object> User)
        {
            User.Add("UserCode", "Orkan");
            User.Add("UserName", "Icardi");

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionString"]))
            {
                // Bağlantıyı aç
                connection.Open();

                // Veritabanından veri almak için kullanılacak sorgu
                string query = $"update Meta_User set UserName = @UserName where UserCode = @UserCode";

                // SQL komutunu ve bağlantıyı oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleyerek SQL enjeksiyonundan korunma
                    command.Parameters.AddWithValue("@UserName", User["UserName"]);
                    command.Parameters.AddWithValue("@UserCode", User["UserCode"]);

                    // Komutu çalıştır ve etkilenen satır sayısını al
                    int rowsAffected = command.ExecuteNonQuery();

                    // Eğer hiç satır etkilenmediyse, silme işlemi başarısızdır
                    if (rowsAffected == 0)
                    {
                        return Ok("Güncelleme işlemi başarısız oldu.");
                    }
                    else
                    {
                        return Ok("Güncelleme başarılı oldu.");
                    }
                }
            }
        }
    }
}
