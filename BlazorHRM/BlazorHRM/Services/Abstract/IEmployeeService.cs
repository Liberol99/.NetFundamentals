using BlazorHRM.Models;

namespace BlazorHRM.Services.Abstract
{
    public interface IEmployeeService
    {
        public void AddEmployee(Employee employee);
        public void RemoveEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public Employee GetEmployee(long recId);
        public List<Employee> GetAllEmployees();
    }
}
