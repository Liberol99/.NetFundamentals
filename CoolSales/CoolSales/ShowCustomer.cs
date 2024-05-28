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
    public partial class ShowCustomer : Form
    {
        CustomerManager customerManager = new CustomerManager();
        public ShowCustomer()
        {
            InitializeComponent();
        }

        private void ShowCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerManager.GetAll();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerManager.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustFirstName=txtFirstName.Text,
                CustLastName=txtLastName.Text,
                CustCity=txtCity.Text,
                CustStreetAddress=txtAdress.Text
            };
            customerManager.AddValue(customer);
            dataGridView1.DataSource = customerManager.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = Convert.ToInt32(txtCustomerId.Text),
                CustFirstName = txtFirstName.Text,
                CustLastName = txtLastName.Text,
                CustCity = txtCity.Text,
                CustStreetAddress = txtAdress.Text
            };
            customerManager.UpdateValue(customer);
            dataGridView1.DataSource = customerManager.GetAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            customerManager.DeleteValue(Convert.ToInt32(txtCustomerId.Text));
            dataGridView1.DataSource = customerManager.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text= "";
            txtAdress.Text = "";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Text = dataGridView1.CurrentRow.Cells["CustomerId"].Value.ToString();
            txtFirstName.Text = dataGridView1.CurrentRow.Cells["CustFirstName"].Value.ToString();
            txtLastName.Text = dataGridView1.CurrentRow.Cells["CustLastName"].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells["CustCity"].Value.ToString();
            txtAdress.Text = dataGridView1.CurrentRow.Cells["CustStreetAddress"].Value.ToString();

        }
    }
}
