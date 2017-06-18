using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class TaxTypeDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<TaxType> TaxTypeDaoRepository;

        public TaxTypeDao()
        {
            TaxTypeDaoRepository = unitOfWork.Repository<TaxType>();
        }

        public bool Validate(TaxType _TaxType, out List<string> lstMessages)
        {
            return TaxTypeDaoRepository.Validate(_TaxType, out lstMessages);
        }

        public int Insert(TaxType _TaxType)
        {
            return TaxTypeDaoRepository.Insert(_TaxType);
        }

        public int Update(TaxType _TaxType)
        {
            return TaxTypeDaoRepository.Update(_TaxType);
        }

        public int Delete(TaxType _TaxType)
        {
            return TaxTypeDaoRepository.Delete(_TaxType);
        }

        public async Task<TaxType> GetById(int _id)
        {
            return await TaxTypeDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<TaxType>> GetAll()
        {
            return await TaxTypeDaoRepository.GetAll();
        }

        public async Task<IEnumerable<TaxType>> FindBy(Expression<Func<TaxType, bool>> predicate)
        {
            return await TaxTypeDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<TaxType>> GetAllBy(Expression<Func<TaxType, bool>> filter = null, Func<IEnumerable<TaxType>, IOrderedEnumerable<TaxType>> orderBy = null)
        {
            return await TaxTypeDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
