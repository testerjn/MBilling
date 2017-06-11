using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class TaxRateDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<TaxRate> TaxRateDaoRepository;

        public TaxRateDao()
        {
            TaxRateDaoRepository = unitOfWork.Repository<TaxRate>();
        }

        public bool Validate(TaxRate _TaxRate,out List<string> lstMessages)
        {
            return TaxRateDaoRepository.Validate(_TaxRate,out lstMessages);
        }

        public int Insert(TaxRate _TaxRate)
        {
            return TaxRateDaoRepository.Insert(_TaxRate);
        }

        public int Update(TaxRate _TaxRate)
        {
            return TaxRateDaoRepository.Update(_TaxRate);
        }

        public int Delete(TaxRate _TaxRate)
        {
            return TaxRateDaoRepository.Delete(_TaxRate);
        }

        public async Task<TaxRate> GetById(int _id)
        {
            return await TaxRateDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<TaxRate>> GetAll()
        {
            return await TaxRateDaoRepository.GetAll();
        }

        public async Task<IEnumerable<TaxRate>> FindBy(Expression<Func<TaxRate, bool>> predicate)
        {
            return await TaxRateDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<TaxRate>> GetAllBy(Expression<Func<TaxRate, bool>> filter = null, Func<IEnumerable<TaxRate>, IOrderedEnumerable<TaxRate>> orderBy = null)
        {
            return await TaxRateDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
