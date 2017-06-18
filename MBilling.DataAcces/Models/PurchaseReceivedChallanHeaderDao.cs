using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PurchaseReceivedChallanHeaderDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PurchaseReceivedChallanHeader> PurchaseReceivedChallanHeaderDaoRepository;

        public PurchaseReceivedChallanHeaderDao()
        {
            PurchaseReceivedChallanHeaderDaoRepository = unitOfWork.Repository<PurchaseReceivedChallanHeader>();
        }

        public bool Validate(PurchaseReceivedChallanHeader _PurchaseReceivedChallanHeader, out List<string> lstMessages)
        {
            return PurchaseReceivedChallanHeaderDaoRepository.Validate(_PurchaseReceivedChallanHeader, out lstMessages);
        }

        public int Insert(PurchaseReceivedChallanHeader _PurchaseReceivedChallanHeader)
        {
            return PurchaseReceivedChallanHeaderDaoRepository.Insert(_PurchaseReceivedChallanHeader);
        }

        public int Update(PurchaseReceivedChallanHeader _PurchaseReceivedChallanHeader)
        {
            return PurchaseReceivedChallanHeaderDaoRepository.Update(_PurchaseReceivedChallanHeader);
        }

        public int Delete(PurchaseReceivedChallanHeader _PurchaseReceivedChallanHeader)
        {
            return PurchaseReceivedChallanHeaderDaoRepository.Delete(_PurchaseReceivedChallanHeader);
        }

        public async Task<PurchaseReceivedChallanHeader> GetById(int _id)
        {
            return await PurchaseReceivedChallanHeaderDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PurchaseReceivedChallanHeader>> GetAll()
        {
            return await PurchaseReceivedChallanHeaderDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PurchaseReceivedChallanHeader>> FindBy(Expression<Func<PurchaseReceivedChallanHeader, bool>> predicate)
        {
            return await PurchaseReceivedChallanHeaderDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PurchaseReceivedChallanHeader>> GetAllBy(Expression<Func<PurchaseReceivedChallanHeader, bool>> filter = null, Func<IEnumerable<PurchaseReceivedChallanHeader>, IOrderedEnumerable<PurchaseReceivedChallanHeader>> orderBy = null)
        {
            return await PurchaseReceivedChallanHeaderDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
