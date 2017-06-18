using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class QuotationHeaderDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<QuotationHeader> QuotationHeaderDaoRepository;

        public QuotationHeaderDao()
        {
            QuotationHeaderDaoRepository = unitOfWork.Repository<QuotationHeader>();
        }

        public bool Validate(QuotationHeader _QuotationHeader, out List<string> lstMessages)
        {
            return QuotationHeaderDaoRepository.Validate(_QuotationHeader, out lstMessages);
        }

        public int Insert(QuotationHeader _QuotationHeader)
        {
            return QuotationHeaderDaoRepository.Insert(_QuotationHeader);
        }

        public int Update(QuotationHeader _QuotationHeader)
        {
            return QuotationHeaderDaoRepository.Update(_QuotationHeader);
        }

        public int Delete(QuotationHeader _QuotationHeader)
        {
            return QuotationHeaderDaoRepository.Delete(_QuotationHeader);
        }

        public async Task<QuotationHeader> GetById(int _id)
        {
            return await QuotationHeaderDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<QuotationHeader>> GetAll()
        {
            return await QuotationHeaderDaoRepository.GetAll();
        }

        public async Task<IEnumerable<QuotationHeader>> FindBy(Expression<Func<QuotationHeader, bool>> predicate)
        {
            return await QuotationHeaderDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<QuotationHeader>> GetAllBy(Expression<Func<QuotationHeader, bool>> filter = null, Func<IEnumerable<QuotationHeader>, IOrderedEnumerable<QuotationHeader>> orderBy = null)
        {
            return await QuotationHeaderDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
