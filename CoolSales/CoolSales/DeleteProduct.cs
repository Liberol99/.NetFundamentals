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
    public partial class DeleteProduct : Form
    {
        ProductManager productManager = new ProductManager();
        int productId;
        public DeleteProduct(int ProductId)
        {
            productId = ProductId;
            InitializeComponent();
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productManager.GetAll();
        }

        private void btn_YazilariTemizle_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductDescription.Text = "";
            txtQuantityOnHand.Text = "";
            txtRetailPrice.Text = "";
            txtVendor.Text = "";
            txtCategory.Text = "";
        }

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
            productManager.DeleteValue(Convert.ToInt32(txtProductId.Text));
            dataGridView1.DataSource = productManager.GetAll();
        }
    }
}
