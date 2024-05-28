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
    public class ShipperManager : IShipperService
    {
        IShipperDal _shipperDal;

        public ShipperManager(IShipperDal shipperDal)
        {
            _shipperDal = shipperDal;
        }

        public Shipper GetById(int id)
        {
            return _shipperDal.GetById(id);
        }

        public List<Shipper> GetListAll()
        {
            return _shipperDal.GetListAll();
        }

        public List<Shipper> GetListAll(Expression<Func<Shipper, bool>> filter)
        {
            return _shipperDal.GetListAll(filter);
        }

        public void TAdd(Shipper t)
        {
            _shipperDal.Insert(t);
        }

        public void TDelete(Shipper t)
        {
            _shipperDal.Delete(t);
        }

        public void TUpdate(Shipper t)
        {
            _shipperDal.Update(t);
        }
    }
}
