using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PurchaseReceivedChallanDetailDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PurchaseReceivedChallanDetail> PurchaseReceivedChallanDetailDaoRepository;

        public PurchaseReceivedChallanDetailDao()
        {
            PurchaseReceivedChallanDetailDaoRepository = unitOfWork.Repository<PurchaseReceivedChallanDetail>();
        }

        public bool Validate(PurchaseReceivedChallanDetail _PurchaseReceivedChallanDetail, out List<string> lstMessages)
        {
            return PurchaseReceivedChallanDetailDaoRepository.Validate(_PurchaseReceivedChallanDetail, out lstMessages);
        }

        public int Insert(PurchaseReceivedChallanDetail _PurchaseReceivedChallanDetail)
        {
            return PurchaseReceivedChallanDetailDaoRepository.Insert(_PurchaseReceivedChallanDetail);
        }

        public int Update(PurchaseReceivedChallanDetail _PurchaseReceivedChallanDetail)
        {
            return PurchaseReceivedChallanDetailDaoRepository.Update(_PurchaseReceivedChallanDetail);
        }

        public int Delete(PurchaseReceivedChallanDetail _PurchaseReceivedChallanDetail)
        {
            return PurchaseReceivedChallanDetailDaoRepository.Delete(_PurchaseReceivedChallanDetail);
        }

        public async Task<PurchaseReceivedChallanDetail> GetById(int _id)
        {
            return await PurchaseReceivedChallanDetailDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PurchaseReceivedChallanDetail>> GetAll()
        {
            return await PurchaseReceivedChallanDetailDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PurchaseReceivedChallanDetail>> FindBy(Expression<Func<PurchaseReceivedChallanDetail, bool>> predicate)
        {
            return await PurchaseReceivedChallanDetailDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PurchaseReceivedChallanDetail>> GetAllBy(Expression<Func<PurchaseReceivedChallanDetail, bool>> filter = null, Func<IEnumerable<PurchaseReceivedChallanDetail>, IOrderedEnumerable<PurchaseReceivedChallanDetail>> orderBy = null)
        {
            return await PurchaseReceivedChallanDetailDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
