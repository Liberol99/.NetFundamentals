using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelFundamentals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter= "Excel Dosyaları|*.xlsx|Excel Dosyaları 97-2003|*.xls", Title="EXCEL DOSYALARI"})
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFile.FileName;
                    using (var stream = File.Open(openFile.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using (IExcelDataReader excelReader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration() 
                            {
                                ConfigureDataTable = (x)=>new ExcelDataTableConfiguration() { UseHeaderRow= true }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable dt in tableCollection)
                            {
                                comboBox1.Items.Add(dt.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedIndex];
            dataGridView1.DataSource = dt;
        }
    }
}
