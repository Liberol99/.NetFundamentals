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
    public partial class AddProduct : Form
    {
        ProductManager productManager = new ProductManager();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productManager.GetAll();
            using var c = new Context();
            var values1 = c.Categories.Select(x => x.CategoryName).ToList();
            foreach (var item in values1)
            {
                comboBox1.Items.Add(item);
            }
            var values = c.Vendors.Select(x => x.VendName).ToList();
            foreach (var item in values)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var c = new Context();
            int CategoryId = c.Categories.Where(x => x.CategoryName == comboBox1.SelectedItem.ToString()).Select(x=>x.CategoryId).SingleOrDefault();
            int VendorId = c.Vendors.Where(x => x.VendName == comboBox2.SelectedItem.ToString()).Select(x=>x.VendorId).SingleOrDefault();
            Product product = new Product()
            {
                ProductName = txtProductName.Text,
                ProductDescription = txtProductDescription.Text,
                RetailPrice = Convert.ToDecimal(txtRetailPrice.Text),
                QuantityOnHand=txtQuantityOnHand.Text,
                VendorId = VendorId,
                CategoryId = CategoryId
            };
            productManager.AddValue(product);
            dataGridView1.DataSource = productManager.GetAll();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            txtProductDescription.Text = dataGridView1.CurrentRow.Cells["ProductDescription"].Value.ToString();
            txtQuantityOnHand.Text = dataGridView1.CurrentRow.Cells["QuantityOnHand"].Value.ToString();
            txtRetailPrice.Text = dataGridView1.CurrentRow.Cells["RetailPrice"].Value.ToString();
        }

        private void btn_YazilariTemizle_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductDescription.Text = "";
            txtQuantityOnHand.Text = "";
            txtRetailPrice.Text = "";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }
    }
}
