using CoolSales.BogusData;
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
    public partial class Form1 : Form
    {
        ProductManager productManager = new ProductManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Name = "Ürün Yönetimi";
            dataGridView1.DataSource = productManager.GetAll();
        }

        ////private void panel2_Paint(object sender, PaintEventArgs e)
        ////{

        ////}

        ////private void textBox6_TextChanged(object sender, EventArgs e)
        ////{

        ////}

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            txtProductDescription.Text = dataGridView1.CurrentRow.Cells["ProductDescription"].Value.ToString();
            txtQuantityOnHand.Text = dataGridView1.CurrentRow.Cells["QuantityOnHand"].Value.ToString();
            txtRetailPrice.Text = dataGridView1.CurrentRow.Cells["RetailPrice"].Value.ToString();
            txtVendor.Text = dataGridView1.CurrentRow.Cells["VendorId"].Value.ToString();
            txtCategory.Text = dataGridView1.CurrentRow.Cells["CategoryId"].Value.ToString();
            txtProductId.Text = dataGridView1.CurrentRow.Cells["ProductId"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct(Convert.ToInt32(txtProductId.Text),txtProductName.Text,txtProductDescription.Text,txtQuantityOnHand.Text,Convert.ToInt32(txtVendor.Text), Convert.ToInt32(txtCategory.Text), Convert.ToDecimal(txtRetailPrice.Text));
            updateProduct.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct(Convert.ToInt32(txtProductId.Text));
            deleteProduct.Show();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productManager.GetAll();
        }
    }
}
