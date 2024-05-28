using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;

namespace ExcelFundamentals
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            //istenilen sayfa sayısı index olarak girilir.
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    //ilk satır atlanıyor çünkü alanlar kolon isimlerinden geliyor
                    alan2.Cells[2, 1] = dataGridView1[i,j].Value;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //kolon tanımı, aktarma işlemlerinde bu satır atlanıyor
            dataGridView1.Columns.Add("Contact Name", "Contact Name");
            dataGridView1.Columns.Add("Contact Title", "Contact Title");
            dataGridView1.Columns.Add("Company Name", "Company Name");
            dataGridView1.Columns.Add("Full Address", "Full Address");

            //aktarılacak veriler
            dataGridView1.Rows.Add("Orkan", "Computer Engineer", "Sentez Yazılım", "Şirinevler");
            dataGridView1.Rows.Add("Mustafa", "Machine Engineer", "Sentez Yazılım", "Şirinevler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            //istenilen sayfa sayısı index olarak girilir.
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.SelectedRows[i].Cells.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[i + 1, j + 1];
                    alan2.Cells[2, 1] = dataGridView1.SelectedRows[i].Cells[j].Value;
                }
            }
        }
    }
}