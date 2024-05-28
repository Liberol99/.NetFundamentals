using FastReport;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastReportCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataSet GetDataSet(string query)
        {
            // SQL Server bağlantı dizesi
            string connectionString = @"Server=DESKTOP-TUSNPG5\SQL22;Database=DogruolDb;Trusted_Connection=True;";

            // SqlConnection oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SqlCommand oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // DataTable oluştur
                    DataTable dataTable = new DataTable();

                    // DataSet oluştur
                    DataSet dataSet = new DataSet();
                    try
                    {
                        // Bağlantıyı aç
                        connection.Open();

                        // SqlDataReader oluştur
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // SqlDataReader'dan DataTable'e veri aktar
                            dataTable.Load(reader);
                            dataSet.Tables.Add(dataTable);
                            return dataSet;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                        return dataSet;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {

        }

        private void btnBankaBakiye_Click(object sender, EventArgs e)
        {

        }
        bool RaporTasariMMi = false;
        private void btnStok_Click(object sender, EventArgs e)
        {
            Report report1 = new Report();
            //string sqlEmployee = "";
            //sqlEmployee = "select * from Erp_Employee with(nolock)";
            //report1.RegisterData(GetDataSet(sqlEmployee));
            string sqlUser = "";
            sqlUser = "select top 10 mu.UserName,ee.EmployeeName from Meta_User mu with(nolock) left join Erp_Employee ee on mu.EmployeeId=ee.RecId";
            report1.RegisterData(GetDataSet(sqlUser));

            report1.Load(Application.StartupPath + "\\Rapor\\Rapor1.frx");
            //report1.SetParameterValue("Parametre", "Değer")//rapora sadece parametrede yollayabilirsiniz istediğiniz kadar eklenebilir

            //report1.PrintSettings.ShowDialog = false;
            //report1.PrintSettings.Printer = "Aclas Printer";
            //report1.PrintSettings.Copies = 1;
            //report1.PrintPrepared();
            //report1.Print();

            if (!RaporTasariMMi)
            {
                report1.Show();
            }
            else
            {
                report1.Design();
            }
        }

        private void chkTasarim_CheckedChanged(object sender, EventArgs e)
        {
            RaporTasariMMi = chkTasarim.Checked;
        }
    }
}
