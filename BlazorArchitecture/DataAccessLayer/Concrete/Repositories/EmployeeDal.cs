using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class EmployeeDal : GenericDal<Employee>, IEmployeeDal
    {
    }
}
