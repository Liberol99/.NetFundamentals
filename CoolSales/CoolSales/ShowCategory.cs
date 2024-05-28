using CoolSales.Models;
using CoolSales.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSales
{
    public partial class ShowCategory : Form
    {
        CategoryManager categoryManager = new CategoryManager();
        public ShowCategory()
        {
            InitializeComponent();
        }

        private void ShowCategory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryManager.GetAll();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryName.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtCategoryDescription.Text = dataGridView1.CurrentRow.Cells["CategoryDescription"].Value.ToString();
            txtCategoryId.Text = dataGridView1.CurrentRow.Cells["CategoryId"].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            categoryManager.DeleteValue(Convert.ToInt32(txtCategoryId.Text));
            dataGridView1.DataSource = categoryManager.GetAll();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryManager.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryId=Convert.ToInt32(txtCategoryId.Text),
                CategoryName = txtCategoryName.Text,
                CategoryDescription = txtCategoryDescription.Text,
            };
            categoryManager.UpdateValue(category);
            dataGridView1.DataSource = categoryManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryName = txtCategoryName.Text,
                CategoryDescription = txtCategoryDescription.Text,
            };
            categoryManager.AddValue(category);
            dataGridView1.DataSource = categoryManager.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            txtCategoryDescription.Text = "";
        }
    }
}
