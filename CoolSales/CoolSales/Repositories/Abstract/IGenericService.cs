using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSales.Repositories.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetValue(int id);
        void AddValue(T t);
        void UpdateValue(T t);
        void DeleteValue(int id);
    }
}
