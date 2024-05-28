using ApiLayer.Models;
using System.Collections.Generic;

namespace ApiLayer.Repositories
{
    public interface IAccountingService
    {
        List<Accounting> GetAllAccounting();
        Accounting GetAccounting(int id);
        void UpdateAccounting(Accounting accounting);
        void DeleteAccounting(int id);
        void AddAccounting(Accounting accounting);
    }
}
