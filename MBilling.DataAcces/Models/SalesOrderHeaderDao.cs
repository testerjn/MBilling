using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class SalesOrderHeaderDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<SalesOrderHeader> SalesOrderHeaderDaoRepository;

        public SalesOrderHeaderDao()
        {
            SalesOrderHeaderDaoRepository = unitOfWork.Repository<SalesOrderHeader>();
        }

        public bool Validate(SalesOrderHeader _SalesOrderHeader, out List<string> lstMessages)
        {
            return SalesOrderHeaderDaoRepository.Validate(_SalesOrderHeader, out lstMessages);
        }

        public int Insert(SalesOrderHeader _SalesOrderHeader)
        {
            return SalesOrderHeaderDaoRepository.Insert(_SalesOrderHeader);
        }

        public int Update(SalesOrderHeader _SalesOrderHeader)
        {
            return SalesOrderHeaderDaoRepository.Update(_SalesOrderHeader);
        }

        public int Delete(SalesOrderHeader _SalesOrderHeader)
        {
            return SalesOrderHeaderDaoRepository.Delete(_SalesOrderHeader);
        }

        public async Task<SalesOrderHeader> GetById(int _id)
        {
            return await SalesOrderHeaderDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<SalesOrderHeader>> GetAll()
        {
            return await SalesOrderHeaderDaoRepository.GetAll();
        }

        public async Task<IEnumerable<SalesOrderHeader>> FindBy(Expression<Func<SalesOrderHeader, bool>> predicate)
        {
            return await SalesOrderHeaderDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<SalesOrderHeader>> GetAllBy(Expression<Func<SalesOrderHeader, bool>> filter = null, Func<IEnumerable<SalesOrderHeader>, IOrderedEnumerable<SalesOrderHeader>> orderBy = null)
        {
            return await SalesOrderHeaderDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
