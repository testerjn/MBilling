using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PurchaseOrderDetailDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PurchaseOrderDetail> PurchaseOrderDetailDaoRepository;

        public PurchaseOrderDetailDao()
        {
            PurchaseOrderDetailDaoRepository = unitOfWork.Repository<PurchaseOrderDetail>();
        }

        public bool Validate(PurchaseOrderDetail _PurchaseOrderDetail, out List<string> lstMessages)
        {
            return PurchaseOrderDetailDaoRepository.Validate(_PurchaseOrderDetail, out lstMessages);
        }

        public int Insert(PurchaseOrderDetail _PurchaseOrderDetail)
        {
            return PurchaseOrderDetailDaoRepository.Insert(_PurchaseOrderDetail);
        }

        public int Update(PurchaseOrderDetail _PurchaseOrderDetail)
        {
            return PurchaseOrderDetailDaoRepository.Update(_PurchaseOrderDetail);
        }

        public int Delete(PurchaseOrderDetail _PurchaseOrderDetail)
        {
            return PurchaseOrderDetailDaoRepository.Delete(_PurchaseOrderDetail);
        }

        public async Task<PurchaseOrderDetail> GetById(int _id)
        {
            return await PurchaseOrderDetailDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PurchaseOrderDetail>> GetAll()
        {
            return await PurchaseOrderDetailDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PurchaseOrderDetail>> FindBy(Expression<Func<PurchaseOrderDetail, bool>> predicate)
        {
            return await PurchaseOrderDetailDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PurchaseOrderDetail>> GetAllBy(Expression<Func<PurchaseOrderDetail, bool>> filter = null, Func<IEnumerable<PurchaseOrderDetail>, IOrderedEnumerable<PurchaseOrderDetail>> orderBy = null)
        {
            return await PurchaseOrderDetailDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
