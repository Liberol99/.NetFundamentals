using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BusinessLayer.AdoNet
{
    public class AdoManager : IAdoService
    {
        private readonly IConfiguration _configuration;

        public AdoManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DataTable SelectQuery(string query)
        {
            // Bağlantı dizesi
            string connectionString = _configuration["ConnectionStrings:Connection"];

            // SqlConnection oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SqlCommand ve SqlDataReader oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // DataTable oluştur
                    DataTable dataTable = new DataTable();

                    // SqlDataReader'dan sütunları ekleyerek DataTable şemasını oluştur
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataTable.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                    }

                    // SqlDataReader'dan verileri okuyarak DataTable'e ekle
                    while (reader.Read())
                    {
                        DataRow dataRow = dataTable.NewRow();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dataRow[i] = reader[i];
                        }

                        dataTable.Rows.Add(dataRow);
                    }

                    return dataTable;
                }
            }
        }
    }
}
