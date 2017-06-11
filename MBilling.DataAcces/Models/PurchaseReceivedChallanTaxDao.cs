using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PurchaseReceivedChallanTaxDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PurchaseReceivedChallanTax> PurchaseReceivedChallanTaxDaoRepository;

        public PurchaseReceivedChallanTaxDao()
        {
            PurchaseReceivedChallanTaxDaoRepository = unitOfWork.Repository<PurchaseReceivedChallanTax>();
        }

        public bool Validate(PurchaseReceivedChallanTax _PurchaseReceivedChallanTax, out List<string> lstMessages)
        {
            return PurchaseReceivedChallanTaxDaoRepository.Validate(_PurchaseReceivedChallanTax, out lstMessages);
        }

        public int Insert(PurchaseReceivedChallanTax _PurchaseReceivedChallanTax)
        {
            return PurchaseReceivedChallanTaxDaoRepository.Insert(_PurchaseReceivedChallanTax);
        }

        public int Update(PurchaseReceivedChallanTax _PurchaseReceivedChallanTax)
        {
            return PurchaseReceivedChallanTaxDaoRepository.Update(_PurchaseReceivedChallanTax);
        }

        public int Delete(PurchaseReceivedChallanTax _PurchaseReceivedChallanTax)
        {
            return PurchaseReceivedChallanTaxDaoRepository.Delete(_PurchaseReceivedChallanTax);
        }

        public async Task<PurchaseReceivedChallanTax> GetById(int _id)
        {
            return await PurchaseReceivedChallanTaxDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PurchaseReceivedChallanTax>> GetAll()
        {
            return await PurchaseReceivedChallanTaxDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PurchaseReceivedChallanTax>> FindBy(Expression<Func<PurchaseReceivedChallanTax, bool>> predicate)
        {
            return await PurchaseReceivedChallanTaxDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PurchaseReceivedChallanTax>> GetAllBy(Expression<Func<PurchaseReceivedChallanTax, bool>> filter = null, Func<IEnumerable<PurchaseReceivedChallanTax>, IOrderedEnumerable<PurchaseReceivedChallanTax>> orderBy = null)
        {
            return await PurchaseReceivedChallanTaxDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
