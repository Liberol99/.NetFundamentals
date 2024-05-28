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
    public partial class ShowEmployee : Form
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public ShowEmployee()
        {
            InitializeComponent();
        }

        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeManager.GetAll();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeId.Text = dataGridView1.CurrentRow.Cells["EmployeeId"].Value.ToString();
            txtFirstName.Text = dataGridView1.CurrentRow.Cells["EmpFirstName"].Value.ToString();
            txtLastName.Text = dataGridView1.CurrentRow.Cells["EmpLastName"].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells["EmpCity"].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells["EmpPhoneNumber"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["EmpBirthDate"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmpFirstName = txtFirstName.Text,
                EmpLastName = txtLastName.Text,
                EmpCity = txtCity.Text,
                EmpPhoneNumber = txtPhone.Text,
                EmpBirthDate = dateTimePicker1.Value
            };
            employeeManager.AddValue(employee);
            dataGridView1.DataSource = employeeManager.GetAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            employeeManager.DeleteValue(Convert.ToInt32(txtEmployeeId.Text));
            dataGridView1.DataSource = employeeManager.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeId = Convert.ToInt32(txtEmployeeId.Text),
                EmpFirstName = txtFirstName.Text,
                EmpLastName = txtLastName.Text,
                EmpCity = txtCity.Text,
                EmpPhoneNumber = txtPhone.Text,
                EmpBirthDate = dateTimePicker1.Value
            };
            employeeManager.UpdateValue(employee);
            dataGridView1.DataSource = employeeManager.GetAll();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeManager.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtCity.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
