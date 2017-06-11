using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class QuotationDetailDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<QuotationDetail> QuotationDetailDaoRepository;

        public QuotationDetailDao()
        {
            QuotationDetailDaoRepository = unitOfWork.Repository<QuotationDetail>();
        }

        public bool Validate(QuotationDetail _QuotationDetail, out List<string> lstMessages)
        {
            return QuotationDetailDaoRepository.Validate(_QuotationDetail, out lstMessages);
        }

        public int Insert(QuotationDetail _QuotationDetail)
        {
            return QuotationDetailDaoRepository.Insert(_QuotationDetail);
        }

        public int Update(QuotationDetail _QuotationDetail)
        {
            return QuotationDetailDaoRepository.Update(_QuotationDetail);
        }

        public int Delete(QuotationDetail _QuotationDetail)
        {
            return QuotationDetailDaoRepository.Delete(_QuotationDetail);
        }

        public async Task<QuotationDetail> GetById(int _id)
        {
            return await QuotationDetailDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<QuotationDetail>> GetAll()
        {
            return await QuotationDetailDaoRepository.GetAll();
        }

        public async Task<IEnumerable<QuotationDetail>> FindBy(Expression<Func<QuotationDetail, bool>> predicate)
        {
            return await QuotationDetailDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<QuotationDetail>> GetAllBy(Expression<Func<QuotationDetail, bool>> filter = null, Func<IEnumerable<QuotationDetail>, IOrderedEnumerable<QuotationDetail>> orderBy = null)
        {
            return await QuotationDetailDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
