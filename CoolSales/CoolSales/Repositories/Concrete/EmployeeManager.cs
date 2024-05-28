using CoolSales.Models;
using CoolSales.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Repositories.Concrete
{
    internal class EmployeeManager : IEmployeeService
    {
        public void AddValue(Employee t)
        {
            using var c = new Context();
            c.Set<Employee>().Add(t);
            c.SaveChanges();
        }

        public void DeleteValue(int id)
        {
            using var c = new Context();
            var value = c.Set<Employee>().Find(id);
            c.Set<Employee>().Remove(value);
            c.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            using var c = new Context();
            return c.Set<Employee>().ToList();
        }

        public Employee GetValue(int id)
        {
            using var c = new Context();
            return c.Set<Employee>().Where(x => x.EmployeeId == id).FirstOrDefault();
        }

        public void UpdateValue(Employee t)
        {
            using var c = new Context();
            c.Set<Employee>().Update(t);
            c.SaveChanges();
        }
    }
}
