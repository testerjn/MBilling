using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PurchaseOrderHeaderDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PurchaseOrderHeader> PurchaseOrderHeaderDaoRepository;

        public PurchaseOrderHeaderDao()
        {
            PurchaseOrderHeaderDaoRepository = unitOfWork.Repository<PurchaseOrderHeader>();
        }

        public bool Validate(PurchaseOrderHeader _PurchaseOrderHeader, out List<string> lstMessages)
        {
            return PurchaseOrderHeaderDaoRepository.Validate(_PurchaseOrderHeader, out lstMessages);
        }

        public int Insert(PurchaseOrderHeader _PurchaseOrderHeader)
        {
            return PurchaseOrderHeaderDaoRepository.Insert(_PurchaseOrderHeader);
        }

        public int Update(PurchaseOrderHeader _PurchaseOrderHeader)
        {
            return PurchaseOrderHeaderDaoRepository.Update(_PurchaseOrderHeader);
        }

        public int Delete(PurchaseOrderHeader _PurchaseOrderHeader)
        {
            return PurchaseOrderHeaderDaoRepository.Delete(_PurchaseOrderHeader);
        }

        public async Task<PurchaseOrderHeader> GetById(int _id)
        {
            return await PurchaseOrderHeaderDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PurchaseOrderHeader>> GetAll()
        {
            return await PurchaseOrderHeaderDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PurchaseOrderHeader>> FindBy(Expression<Func<PurchaseOrderHeader, bool>> predicate)
        {
            return await PurchaseOrderHeaderDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PurchaseOrderHeader>> GetAllBy(Expression<Func<PurchaseOrderHeader, bool>> filter = null, Func<IEnumerable<PurchaseOrderHeader>, IOrderedEnumerable<PurchaseOrderHeader>> orderBy = null)
        {
            return await PurchaseOrderHeaderDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
