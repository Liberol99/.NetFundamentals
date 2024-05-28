using SendMailAndPassOperations.Services.Abstract;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Data;

namespace SendMailAndPassOperations.Services.Concrete
{
    public class SendMailManager : ISendMailService
    {
        private IConfiguration _configuration { get; set; }
        public SendMailManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ForgetPassword(string mail, string pass)
        {
            long recId = CheckUser(mail, pass);
            if (recId > 0)
            {
                NewPassword(recId);
            }
        }

        public void NewPassword(long recId)
        {
            // SQL Server bağlantı dizesini appsettings.json dosyanızdan alın
            string connectionString = $"Server = {_configuration["ConnectionStrings:Server"]}; Database = {_configuration["ConnectionStrings:Database"]}; Trusted_Connection = {_configuration["ConnectionStrings:Trusted_Connection"]};";

            string newPass = Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            // SQL sorgusu
            string query = "update Meta_User set Password = @Password where RecId = @RecId ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Parametrelerin eklenmesi
                command.Parameters.AddWithValue("@Password", newPass);
                command.Parameters.AddWithValue("@RecId", recId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowsAffected > 0)
                    {
                        Dictionary<string, object> mailParams = new Dictionary<string, object>();
                        mailParams.Add("subject", "Yeni Parola !");
                        mailParams.Add("body", newPass);
                        SendMail(mailParams);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }

        public void SendMail(Dictionary<string, object>? mailParams = null)
        {
            try
            {
                // Gmail üzerinden mail göndermek için giriş bilgileri
                string fromAddress = "orkan.koroglu@sentez.com";
                string toAddress = "orkan.koroglu@sentez.com";
                string subject = "Test Mail";
                string body = "Bu bir test mailidir.";

                if (mailParams != null && mailParams.ContainsKey("fromAddress") && mailParams["fromAddress"] != null)
                {
                    fromAddress = mailParams["fromAddress"].ToString();
                }
                if (mailParams != null && mailParams.ContainsKey("toAddress") && mailParams["toAddress"] != null)
                {
                    toAddress = mailParams["toAddress"].ToString();
                }
                if (mailParams != null && mailParams.ContainsKey("subject") && mailParams["subject"] != null)
                {
                    subject = mailParams["subject"].ToString();
                }
                if (mailParams != null && mailParams.ContainsKey("body") && mailParams["body"] != null)
                {
                    body = mailParams["body"].ToString();
                }

                // Gmail SMTP sunucu bilgileri
                SmtpClient smtpClient = new SmtpClient("mail.sentez.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("orkan.koroglu@sentez.com", "orkan1905"),
                    EnableSsl = false,
                };

                // Mail mesajı oluştur
                MailMessage mailMessage = new MailMessage(fromAddress, toAddress, subject, body);

                // Mail gönder
                smtpClient.Send(mailMessage);

                Console.WriteLine("Mail başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail gönderme hatası: " + ex.Message);
            }
        }

        public long CheckUser(string mail, string pass)
        {

            // SQL Server bağlantı dizesini appsettings.json dosyanızdan alın
            string connectionString = $"Server = {_configuration["ConnectionStrings:Server"]}; Database = {_configuration["ConnectionStrings:Database"]}; Trusted_Connection = {_configuration["ConnectionStrings:Trusted_Connection"]};";

            // SQL sorgusu
            string query = $"select top 1 RecId from Meta_User with(nolock) where EMail = '{mail}' and Password = '{pass}' ";

            // SqlConnection oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SqlCommand oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // DataTable oluştur
                    DataTable dataTable = new DataTable();

                    try
                    {
                        // Bağlantıyı aç
                        connection.Open();

                        // SqlDataReader oluştur
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // SqlDataReader'dan DataTable'e veri aktar
                            dataTable.Load(reader);
                        }

                        // Bağlantıyı kapat
                        connection.Close();

                        if (dataTable != null && dataTable.Rows.Count > 0)
                        {
                            return Convert.ToInt64(dataTable.Rows[0]["RecId"]);
                        }
                        else
                        {
                            return 0;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                        return 0;
                    }
                }
            }
        }

        public void ChangePassword(string mail, string newPass)
        {
            // SQL Server bağlantı dizesini appsettings.json dosyanızdan alın
            string connectionString = $"Server = {_configuration["ConnectionStrings:Server"]}; Database = {_configuration["ConnectionStrings:Database"]}; Trusted_Connection = {_configuration["ConnectionStrings:Trusted_Connection"]};";
                       

            // SQL sorgusu
            string query = "update Meta_User set Password = @Password where EMail = @mail";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Parametrelerin eklenmesi
                command.Parameters.AddWithValue("@Password", newPass);
                command.Parameters.AddWithValue("@mail", mail);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowsAffected > 0)
                    {
                        Dictionary<string, object> mailParams = new Dictionary<string, object>();
                        mailParams.Add("subject", "Şifre Değişti !");
                        mailParams.Add("body", newPass);
                        SendMail(mailParams);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }
    }
}
