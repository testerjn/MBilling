using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class SalesOrderTaxDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<SalesOrderTax> SalesOrderTaxDaoRepository;

        public SalesOrderTaxDao()
        {
            SalesOrderTaxDaoRepository = unitOfWork.Repository<SalesOrderTax>();
        }

        public bool Validate(SalesOrderTax _SalesOrderTax, out List<string> lstMessages)
        {
            return SalesOrderTaxDaoRepository.Validate(_SalesOrderTax, out lstMessages);
        }

        public int Insert(SalesOrderTax _SalesOrderTax)
        {
            return SalesOrderTaxDaoRepository.Insert(_SalesOrderTax);
        }

        public int Update(SalesOrderTax _SalesOrderTax)
        {
            return SalesOrderTaxDaoRepository.Update(_SalesOrderTax);
        }

        public int Delete(SalesOrderTax _SalesOrderTax)
        {
            return SalesOrderTaxDaoRepository.Delete(_SalesOrderTax);
        }

        public async Task<SalesOrderTax> GetById(int _id)
        {
            return await SalesOrderTaxDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<SalesOrderTax>> GetAll()
        {
            return await SalesOrderTaxDaoRepository.GetAll();
        }

        public async Task<IEnumerable<SalesOrderTax>> FindBy(Expression<Func<SalesOrderTax, bool>> predicate)
        {
            return await SalesOrderTaxDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<SalesOrderTax>> GetAllBy(Expression<Func<SalesOrderTax, bool>> filter = null, Func<IEnumerable<SalesOrderTax>, IOrderedEnumerable<SalesOrderTax>> orderBy = null)
        {
            return await SalesOrderTaxDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
