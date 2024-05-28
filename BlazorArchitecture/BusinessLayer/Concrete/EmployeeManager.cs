using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            this.employeeDal = employeeDal;
        }

        public void Add(Employee entity)
        {
            employeeDal.Add(entity);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeDal.GetAll();
        }

        public Employee GetById(long recId)
        {
            return employeeDal.GetById(recId);
        }

        public void Remove(Employee entity)
        {
            employeeDal.Remove(entity);
        }

        public void Update(Employee entity)
        {
            employeeDal.Update(entity);
        }
    }
}
