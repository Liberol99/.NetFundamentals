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
    public partial class UpdateProduct : Form
    {
        ProductManager productManager = new ProductManager();
        int productId;
        string productName;
        string productDescription;
        string quantityOnHand;
        int vendId;
        int categoryId;
        decimal retailPrice;

        public UpdateProduct(int ProductId,string ProductName,string ProductDescription,string QuantityOnHand,int VendId,int CategoryId,decimal RetailPrice)
        {
            productId = ProductId;
            productName = ProductName;
            productDescription = ProductDescription;
            quantityOnHand = QuantityOnHand;
            vendId = VendId;
            categoryId = CategoryId;
            retailPrice = RetailPrice;
            InitializeComponent();
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using var c = new Context();
            int CatId = c.Categories.Where(x => x.CategoryName == comboBox2.SelectedItem.ToString()).Select(x => x.CategoryId).SingleOrDefault();
            int VdId = c.Vendors.Where(x => x.VendName == comboBox1.SelectedItem.ToString()).Select(x => x.VendorId).SingleOrDefault();

            Product product = new Product()
            {
                ProductId = Convert.ToInt32(txtProductId.Text),
                ProductName = txtProductName.Text,
                ProductDescription = txtProductDescription.Text,
                QuantityOnHand = txtQuantityOnHand.Text,
                VendorId = VdId,
                CategoryId = CatId,
                RetailPrice = Convert.ToDecimal(txtRetailPrice.Text)
            };
            productManager.UpdateValue(product);
            dataGridView1.DataSource = productManager.GetAll();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productManager.GetAll();
            using var c = new Context();
            var CatName = c.Categories.Where(x => x.CategoryId == categoryId).Select(x => x.CategoryName).SingleOrDefault();
            var VendName = c.Vendors.Where(x => x.VendorId == vendId).Select(x => x.VendName).SingleOrDefault();
            txtProductId.Text = productId.ToString();
            txtProductName.Text = productName;
            txtProductDescription.Text = productDescription;
            txtQuantityOnHand.Text = quantityOnHand;
            comboBox1.Items.Add(VendName);
            comboBox2.Items.Add(CatName);
            comboBox1.SelectedItem = VendName;
            comboBox2.SelectedItem = CatName;
            txtRetailPrice.Text = retailPrice.ToString();
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            txtProductDescription.Text = dataGridView1.CurrentRow.Cells["ProductDescription"].Value.ToString();
            txtQuantityOnHand.Text = dataGridView1.CurrentRow.Cells["QuantityOnHand"].Value.ToString();
            txtRetailPrice.Text = dataGridView1.CurrentRow.Cells["RetailPrice"].Value.ToString();
            txtProductId.Text = dataGridView1.CurrentRow.Cells["ProductId"].Value.ToString();
        }
    }
}
