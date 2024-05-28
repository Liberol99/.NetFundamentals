using AspNetWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebApp
{
    public partial class About : Page
    {
        public static int sayac = 0;

        public static Employee[] employees =
        {
            //new Employee() { Id = "1", FirstName = "Orkan", LastName = "Köroğlu", Age = "23" },
            //new Employee() { Id = "1", FirstName = "Ziya", LastName = "Yıldız", Age = "23" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("RecId", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Price", typeof(int));

            DataRow dataRow = dataTable.NewRow();
            dataRow["RecId"] = 9;
            dataRow["Name"] = "Icardi";
            dataRow["Price"] = 100;
            dataTable.Rows.Add(dataRow);

            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Id = Id.Text,
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                Age = Age.Text
            };

            Array.Resize(ref employees, employees.Length + 1);

            employees[employees.Length - 1] = employee;

            sayac++;

            if (employees != null && employees.Count() > 0)
            {
                TableCell[] cells;
                foreach (var item in employees)
                {
                    TableRow tableRow = new TableRow();
                    cells = new TableCell[]
                    {
                        new TableCell(){Text=item.Id},
                        new TableCell(){Text=item.FirstName},
                        new TableCell(){Text=item.LastName},
                        new TableCell(){Text=item.Age},
                        new TableCell(){Text=Message.message1 },
                        new TableCell(){Text=Message.message2 }
                    };
                    foreach (var cell in cells)
                    {
                        tableRow.Cells.Add(cell);
                    }
                    Table1.Rows.Add(tableRow);
                }
            }
        }
    }
}