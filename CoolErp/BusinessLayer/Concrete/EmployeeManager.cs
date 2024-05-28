using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _empolyeeDal;

        public EmployeeManager(IEmployeeDal empolyeeDal)
        {
            _empolyeeDal = empolyeeDal;
        }

        public Employee GetById(int id)
        {
            return _empolyeeDal.GetById(id);    
        }

        public List<Employee> GetListAll()
        {
            return _empolyeeDal.GetListAll();
        }

        public List<Employee> GetListAll(Expression<Func<Employee, bool>> filter)
        {
            return _empolyeeDal.GetListAll(filter);
        }

        public void TAdd(Employee t)
        {
            _empolyeeDal.Insert(t);
        }

        public void TDelete(Employee t)
        {
            _empolyeeDal.Delete(t);
        }

        public void TUpdate(Employee t)
        {
            _empolyeeDal.Update(t);
        }
    }
}
