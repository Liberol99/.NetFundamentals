using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpCity { get; set; }
        public string EmpPhoneNumber { get; set; }
        public DateTime EmpBirthDate { get; set; }
        public List<Order> Orders { get; set; }
    }
}
