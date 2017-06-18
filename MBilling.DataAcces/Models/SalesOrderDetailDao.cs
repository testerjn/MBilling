using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class SalesOrderDetailDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<SalesOrderDetail> SalesOrderDetailDaoRepository;

        public SalesOrderDetailDao()
        {
            SalesOrderDetailDaoRepository = unitOfWork.Repository<SalesOrderDetail>();
        }

        public bool Validate(SalesOrderDetail _SalesOrderDetail, out List<string> lstMessages)
        {
            return SalesOrderDetailDaoRepository.Validate(_SalesOrderDetail, out lstMessages);
        }

        public int Insert(SalesOrderDetail _SalesOrderDetail)
        {
            return SalesOrderDetailDaoRepository.Insert(_SalesOrderDetail);
        }

        public int Update(SalesOrderDetail _SalesOrderDetail)
        {
            return SalesOrderDetailDaoRepository.Update(_SalesOrderDetail);
        }

        public int Delete(SalesOrderDetail _SalesOrderDetail)
        {
            return SalesOrderDetailDaoRepository.Delete(_SalesOrderDetail);
        }

        public async Task<SalesOrderDetail> GetById(int _id)
        {
            return await SalesOrderDetailDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<SalesOrderDetail>> GetAll()
        {
            return await SalesOrderDetailDaoRepository.GetAll();
        }

        public async Task<IEnumerable<SalesOrderDetail>> FindBy(Expression<Func<SalesOrderDetail, bool>> predicate)
        {
            return await SalesOrderDetailDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<SalesOrderDetail>> GetAllBy(Expression<Func<SalesOrderDetail, bool>> filter = null, Func<IEnumerable<SalesOrderDetail>, IOrderedEnumerable<SalesOrderDetail>> orderBy = null)
        {
            return await SalesOrderDetailDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
